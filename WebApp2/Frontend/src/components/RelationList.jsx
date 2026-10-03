import { useEffect, useState } from "react";
import { get } from "../config/entities";

export default function RelationList({ relation, entity, onChanged }) {
  const [adding, setAdding] = useState(false);
  const [values, setValues] = useState({});
  const [busy, setBusy] = useState(false);
  const [error, setError] = useState("");
  const [options, setOptions] = useState({});

  const relationValue = get(entity, relation.listKey);
  const items = Array.isArray(relationValue)
    ? relationValue
    : relationValue
      ? [relationValue]
      : [];

  useEffect(() => {
    let active = true;
    const fieldsWithOptions = (relation.addFields || []).filter((field) => field.loadOptions);
    Promise.all(
      fieldsWithOptions.map(async (field) => [field.key, await field.loadOptions()])
    ).then((loaded) => {
      if (active) setOptions(Object.fromEntries(loaded));
    }).catch((err) => {
      if (active) setError(err.message);
    });
    return () => { active = false; };
  }, [relation]);

  async function submitAdd(e) {
    e.preventDefault();
    setBusy(true);
    setError("");
    try {
      await relation.onAdd(entity, values);
      setAdding(false);
      setValues({});
      await onChanged();
    } catch (err) {
      setError(err.message);
    } finally {
      setBusy(false);
    }
  }

  async function handleDelete(item) {
    if (!relation.onDelete) return;
    if (!window.confirm("Da li sigurno želite da obrišete ovu stavku?")) return;
    setBusy(true);
    setError("");
    try {
      await relation.onDelete(entity, item);
      await onChanged();
    } catch (err) {
      setError(err.message);
    } finally {
      setBusy(false);
    }
  }

  return (
    <div className="relation-block">
      <div className="relation-header">
        <h4>{relation.label}</h4>
        {relation.addFields && (
          <button type="button" className="relation-add-btn" onClick={() => setAdding((v) => !v)}>
            {adding ? "Otkaži" : "+ Dodaj"}
          </button>
        )}
      </div>

      {items.length === 0 && <p className="relation-empty">Nema podataka.</p>}

      {items.length > 0 && (
        <ul className="relation-list">
          {items.map((item, idx) => (
            <li key={idx}>
              <span>{relation.itemLabel(item)}</span>
              {relation.onDelete && !relation.readOnlyDelete && (
                <button type="button" className="relation-delete-btn" onClick={() => handleDelete(item)} disabled={busy}>
                  Obriši
                </button>
              )}
            </li>
          ))}
        </ul>
      )}

      {adding && relation.addFields && (
        <form className="relation-add-form" onSubmit={submitAdd}>
          {relation.addFields.map((f) => (
            <label key={f.key}>
              <span>{f.label}</span>
              {f.type === "textarea" ? (
                <textarea
                  required={f.required}
                  value={values[f.key] ?? ""}
                  onChange={(e) => setValues((p) => ({ ...p, [f.key]: e.target.value }))}
                />
              ) : f.type === "select" ? (
                <select
                  required={f.required}
                  value={values[f.key] ?? ""}
                  onChange={(e) => setValues((p) => ({ ...p, [f.key]: e.target.value }))}
                >
                  <option value="" disabled>-- izaberite --</option>
                  {(f.options || options[f.key] || []).map((option) => (
                    <option key={option.value} value={option.value}>{option.label}</option>
                  ))}
                </select>
              ) : (
                <input
                  type={f.type === "number" ? "number" : f.type === "date" ? "date" : "text"}
                  required={f.required}
                  value={values[f.key] ?? ""}
                  onChange={(e) => setValues((p) => ({ ...p, [f.key]: e.target.value }))}
                />
              )}
            </label>
          ))}
          <button type="submit" className="control-panel-button relation-submit-btn" disabled={busy}>
            {busy ? "..." : "Sačuvaj"}
          </button>
        </form>
      )}

      {error && <div className="form-error">{error}</div>}
    </div>
  );
}
