export default function SubclassSelect({ types, value, onChange }) {
  if (!types || types.length <= 1) return null;
  return (
    <select className="subclass-select" value={value} onChange={(e) => onChange(e.target.value)}>
      {types.map((t) => (
        <option key={t.key} value={t.key}>
          {t.label}
        </option>
      ))}
    </select>
  );
}
