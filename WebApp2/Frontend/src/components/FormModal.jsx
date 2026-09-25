import { useEffect, useState } from "react";
import Modal from "./Modal";
import { toInputDate } from "../config/entities";

function initialFromFields(fields, initialValues) {
  const values = {};
  for (const f of fields) {
    if (f.type === "hidden") {
      values[f.key] = initialValues?.[f.key];
      continue;
    }
    const raw = initialValues?.[f.key];
    if (f.type === "date") values[f.key] = toInputDate(raw);
    else if (raw === undefined || raw === null) values[f.key] = f.defaultValue ?? (f.type === "number" ? "" : "");
    else values[f.key] = raw;
  }
  return values;
}

function coerceForSubmit(fields, values) {
  const out = {};
  for (const f of fields) {
    const v = values[f.key];
    if (f.type === "number") out[f.key] = v === "" || v === undefined ? undefined : Number(v);
    else if (f.type === "select") {
      const opt = f.options?.find((o) => String(o.value) === String(v));
      out[f.key] = opt ? opt.value : v;
    } else out[f.key] = v;
  }
  return out;
}

export default function FormModal({ title, fields, initialValues, onSubmit, onClose, busy, submitLabel }) {
  const [values, setValues] = useState(() => initialFromFields(fields, initialValues));
  const [error, setError] = useState("");
  const [options, setOptions] = useState({});

  useEffect(() => {
    let active = true;
    const fieldsWithOptions = fields.filter((field) => field.loadOptions);
    Promise.all(
      fieldsWithOptions.map(async (field) => [field.key, await field.loadOptions()])
    ).then((loaded) => {
      if (active) setOptions(Object.fromEntries(loaded));
    }).catch((err) => {
      if (active) setError(err.message);
    });
    return () => { active = false; };
  }, [fields]);

  function set(key, v) {
    setValues((prev) => ({ ...prev, [key]: v }));
  }

  async function handleSubmit(e) {
    e.preventDefault();
    setError("");
    try {
      await onSubmit(coerceForSubmit(fields, values));
    } catch (err) {
      setError(err.message);
    }
  }

  return (
    <Modal title={title} onClose={onClose}>
      <form className="entity-form" onSubmit={handleSubmit}>
        {fields
          .filter((f) => f.type !== "hidden")
          .map((f) => (
            <label key={f.key} className="entity-form-field">
              <span>{f.label}</span>
              {f.type === "textarea" ? (
                <textarea
                  value={values[f.key] ?? ""}
                  required={f.required}
                  placeholder={f.placeholder}
                  onChange={(e) => set(f.key, e.target.value)}
                />
              ) : f.type === "select" ? (
                <select
                  value={values[f.key] ?? ""}
                  required={f.required}
                  onChange={(e) => set(f.key, e.target.value)}
                >
                  <option value="" disabled>
                    -- izaberite --
                  </option>
                  {(f.options || options[f.key] || []).map((o) => (
                    <option key={o.value} value={o.value}>
                      {o.label}
                    </option>
                  ))}
                </select>
              ) : (
                <input
                  type={f.type === "number" ? "number" : f.type === "date" ? "date" : "text"}
                  value={values[f.key] ?? ""}
                  required={f.required}
                  pattern={f.pattern}
                  title={f.title}
                  placeholder={f.placeholder}
                  onChange={(e) => set(f.key, e.target.value)}
                />
              )}
            </label>
          ))}

        {error && <div className="form-error">{error}</div>}

        <div className="entity-form-actions">
          <button type="button" className="control-panel-button" onClick={onClose} disabled={busy}>
            Otkaži
          </button>
          <button type="submit" className="control-panel-button" disabled={busy}>
            {busy ? "Čuvanje..." : submitLabel || "Sačuvaj"}
          </button>
        </div>
      </form>
    </Modal>
  );
}
