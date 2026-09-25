import Modal from "./Modal";
import RelationList from "./RelationList";
import { get } from "../config/entities";

function displayValue(key, value) {
  if (value === null || value === undefined || value === "") return "—";
  if (typeof value === "string" && /^\d{4}-\d{2}-\d{2}T/.test(value)) {
    const d = new Date(value);
    return Number.isNaN(d.getTime()) ? value : d.toLocaleDateString("sr-RS");
  }
  if (typeof value === "object") return "—";
  return String(value);
}

export default function DetailModal({ type, row, onClose, onChanged, onEdit, onDelete, capabilities }) {
  if (!row) return null;

  const idLabel = get(row, type.idKey);

  return (
    <Modal title={`${type.label} — #${idLabel ?? ""}`} onClose={onClose} wide>
      <div className="detail-fields">
        {type.detailFields.map((f) => (
          <div key={f.key} className="detail-field">
            <span className="detail-field-label">{f.label}</span>
            <span className="detail-field-value">{displayValue(f.key, get(row, f.key))}</span>
          </div>
        ))}
      </div>

      {(capabilities?.edit || capabilities?.delete) && (
        <div className="detail-actions">
          {capabilities?.edit && (
            <button type="button" className="control-panel-button" onClick={onEdit}>
              Izmeni
            </button>
          )}
          {capabilities?.delete && (
            <button type="button" className="control-panel-button confirm-danger" onClick={onDelete}>
              Obrisi
            </button>
          )}
        </div>
      )}

      {type.relations.length > 0 && (
        <div className="relations-section">
          <h3>Relacije</h3>
          {type.relations.map((rel) => (
            <RelationList key={rel.key} relation={rel} entity={row} onChanged={onChanged} />
          ))}
        </div>
      )}
    </Modal>
  );
}
