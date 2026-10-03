import Modal from "./Modal";

export default function ConfirmModal({ title, message, onConfirm, onClose, busy }) {
  return (
    <Modal title={title || "Potvrda"} onClose={onClose}>
      <p className="confirm-message">{message}</p>
      <div className="entity-form-actions">
        <button type="button" className="control-panel-button" onClick={onClose} disabled={busy}>
          Otkaži
        </button>
        <button type="button" className="control-panel-button confirm-danger" onClick={onConfirm} disabled={busy}>
          {busy ? "Brisanje..." : "Obriši"}
        </button>
      </div>
    </Modal>
  );
}
