import { useCallback, useEffect, useState } from "react";
import DataTable from "./DataTable";
import ControlPanel from "./ControlPanel";
import SubclassSelect from "./SubclassSelect";
import FormModal from "./FormModal";
import ConfirmModal from "./ConfirmModal";
import DetailModal from "./DetailModal";
import { get } from "../config/entities";

export default function EntityBrowser({ types, TableHeader }) {
  const [typeKey, setTypeKey] = useState(types[0].key);
  const type = types.find((t) => t.key === typeKey) ?? types[0];

  const [rows, setRows] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");
  const [selectedId, setSelectedId] = useState(null);

  const [formMode, setFormMode] = useState(null); // "add" | "edit" | null
  const [showDelete, setShowDelete] = useState(false);
  const [showDetail, setShowDetail] = useState(false);
  const [busy, setBusy] = useState(false);
  const [actionError, setActionError] = useState("");

  const load = useCallback(async () => {
    setLoading(true);
    setError("");
    try {
      const data = await type.api.getAll();
      setRows(Array.isArray(data) ? data : []);
    } catch (e) {
      setError(e.message);
      setRows([]);
    } finally {
      setLoading(false);
    }
  }, [type]);

  useEffect(() => {
    setSelectedId(null);
    load();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [typeKey]);

  const selectedRow = rows.find((r) => get(r, type.idKey) === selectedId) || null;

  function handleRowClick(row) {
    setSelectedId(get(row, type.idKey));
    setShowDetail(true);
  }

  async function handleFormSubmit(values) {
    setBusy(true);
    setActionError("");
    try {
      if (formMode === "add") await type.api.add(values);
      else await type.api.update(values);
      setFormMode(null);
      await load();
    } finally {
      setBusy(false);
    }
  }

  async function handleDeleteConfirm() {
    setBusy(true);
    setActionError("");
    try {
      await type.api.remove(selectedRow);
      setShowDelete(false);
      setShowDetail(false);
      setSelectedId(null);
      await load();
    } catch (e) {
      setActionError(e.message);
    } finally {
      setBusy(false);
    }
  }

  return (
    <div className="items-center flex flex-col">
      {TableHeader}
      <div className=" flex h-15">
      <SubclassSelect types={types} value={typeKey} onChange={setTypeKey} />

      {(type.capabilities?.add) && (
        <div className="flex gap-3 items-center p-5">
          <button type="button" className="control-panel-button" onClick={() => setFormMode("add")}>
            + Dodaj
          </button>
        </div>
      )}
      </div>

      <div className="flex gap-3 items-center p-5">
        <DataTable
          columns={type.columns}
          rows={rows}
          idKey={type.idKey}
          selectedId={selectedId}
          onRowClick={handleRowClick}
          loading={loading}
          error={error}
        />
      </div>

      {formMode && (
        <FormModal
          title={formMode === "add" ? `Dodaj — ${type.label}` : `Izmeni — ${type.label}`}
          fields={formMode === "add" ? type.addFields : type.editFields}
          initialValues={formMode === "edit" ? selectedRow : undefined}
          onSubmit={handleFormSubmit}
          onClose={() => setFormMode(null)}
          busy={busy}
          submitLabel={formMode === "add" ? "Dodaj" : "Sačuvaj izmene"}
        />
      )}

      {showDelete && selectedRow && (
        <ConfirmModal
          title="Brisanje zapisa"
          message={`Da li sigurno želite da obrišete izabrani zapis (#${get(selectedRow, type.idKey)})? Ova akcija je trajna.`}
          onConfirm={handleDeleteConfirm}
          onClose={() => setShowDelete(false)}
          busy={busy}
        />
      )}
      {actionError && <div className="form-error page-level-error">{actionError}</div>}

      {showDetail && selectedRow && (
        <DetailModal
          type={type}
          row={selectedRow}
          capabilities={type.capabilities}
          onClose={() => setShowDetail(false)}
          onChanged={load}
          onEdit={() => {
            setShowDetail(false);
            setFormMode("edit");
          }}
          onDelete={() => {
            setShowDetail(false);
            setShowDelete(true);
          }}
        />
      )}
    </div>
  );
}
