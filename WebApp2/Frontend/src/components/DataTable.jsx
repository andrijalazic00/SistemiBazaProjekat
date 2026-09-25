import { get } from "../config/entities";

export default function DataTable({ columns, rows, idKey, selectedId, onRowClick, loading, error }) {
  return (
    <div className="data-table-wrap h-space w-7xl">
      {loading && <div className="data-table-status">Učitavanje...</div>}
      {!loading && error && <div className="data-table-status data-table-error">{error}</div>}
      {!loading && !error && rows.length === 0 && (
        <div className="data-table-status">Nema podataka za prikaz.</div>
      )}
      {!loading && !error && rows.length > 0 && (
        <table className="data-table">
          <thead>
            <tr>
              {columns.map((c) => (
                <th key={c.key}>{c.label}</th>
              ))}
            </tr>
          </thead>
          <tbody>
            {rows.map((row, i) => {
              const rid = get(row, idKey);
              return (
                <tr
                  key={rid ?? i}
                  className={rid === selectedId ? "data-table-row-selected" : ""}
                  onClick={() => onRowClick(row)}
                >
                  {columns.map((c) => {
                    let val = c.render ? c.render(row) : get(row, c.key);
                    if (c.format) val = c.format(val);
                    if (val !== null && typeof val === "object") val = "";
                    return <td key={c.key}>{val ?? ""}</td>;
                  })}
                </tr>
              );
            })}
          </tbody>
        </table>
      )}
    </div>
  );
}
