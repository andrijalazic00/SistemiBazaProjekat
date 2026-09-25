import * as ep from "../api/endpoints";

export const VIDLJIVOST_OPTIONS = [
  { value: 0, label: "Privatno" },
  { value: 1, label: "Interno" },
];

export const KONACNA_ODLUKA_OPTIONS = [
  { value: "PRIHVACENA", label: "Prihvaćena" },
  { value: "ODBIJENA", label: "Odbijena" },
  { value: "USLOVNO_PRIHVACENA", label: "Uslovno prihvaćena" },
];

export const PREPORUKA_OPTIONS = [
  { value: "DA", label: "Da" },
  { value: "NE", label: "Ne" },
];

/** Safe dotted-path getter, e.g. get(row, "ID_U.ID_I.Ime") */
export function get(obj, path) {
  if (!obj) return undefined;
  return path.split(".").reduce((acc, key) => (acc == null ? undefined : acc[key]), obj);
}

export function fmtDate(value) {
  if (!value) return "";
  const d = new Date(value);
  if (Number.isNaN(d.getTime())) return String(value);
  return d.toLocaleDateString("sr-RS");
}

export function toInputDate(value) {
  if (!value) return "";
  const d = new Date(value);
  if (Number.isNaN(d.getTime())) return "";
  return d.toISOString().slice(0, 10);
}

/* ============================================================
   ISTRAŽIVAČKI REZULTATI (Naučni Rad, Knjiga/Poglavlje, Dataset,
   Tehnički Izveštaj, Softverski Artifakt, Ostali Dokumenti)
   ============================================================ */

const baseIRAddFields = [
  { key: "Naslov", label: "Naslov", type: "text", required: true },
  { key: "Apstrakt", label: "Apstrakt", type: "textarea", required: true },
  { key: "DatumKreiranja", label: "Datum kreiranja", type: "date", required: true },
  { key: "DatumObjavljivanja", label: "Datum objavljivanja", type: "date", required: true },
  {
    key: "StatusIR",
    label: "Status",
    type: "select",
    required: true,
    defaultValue: "POSLAT_NA_RECENZIJU",
    options: [
      { value: "ARHIVIRAN", label: "Arhiviran" },
      { value: "OBJAVLJEN", label: "Objavljen" },
      { value: "POSLAT_NA_RECENZIJU", label: "Poslat na recenziju" },
      { value: "PRIHVACEN", label: "Prihvaćen" },
    ],
  },
  {
    key: "Vidljivost",
    label: "Vidljivost",
    type: "select",
    required: true,
    defaultValue: 0,
    options: VIDLJIVOST_OPTIONS,
  },
];

const baseIREditExtra = [{ key: "ID_IR", type: "hidden" }];

const baseIRColumns = [
  { key: "ID_IR", label: "ID" },
  { key: "Naslov", label: "Naslov" },
  { key: "StatusIR", label: "Status" },
  { key: "DatumObjavljivanja", label: "Objavljeno", format: fmtDate },
];

const kljucneReciRelation = {
  key: "kljucneReci",
  label: "Ključne reči",
  listKey: "KljucneReci",
  itemLabel: (item) => item.Rec,
  addFields: [{ key: "rec", label: "Ključna reč", type: "text", required: true }],
  onAdd: (entity, values) => ep.istrazivackiRezultati.addKljucnaRec(entity.ID_IR, values.rec),
  onDelete: (entity, item) => ep.istrazivackiRezultati.removeKljucnaRec(entity.ID_IR, item.Rec),
};

const verzijeRelation = {
  key: "verzije",
  label: "Verzije",
  listKey: "Verzije",
  itemLabel: (item) =>
    `v${item.BrojVerzije} — ${fmtDate(item.DatumPostavljanja)} (${item.OdgovornaOsoba || ""})`,
  addFields: [
    { key: "BrojVerzije", label: "Broj verzije", type: "number", required: true },
    { key: "DatumPostavljanja", label: "Datum postavljanja", type: "date", required: true },
    { key: "OpisIzmena", label: "Opis izmena", type: "textarea" },
    { key: "OdgovornaOsoba", label: "Odgovorna osoba", type: "text" },
  ],
  onAdd: (entity, values) =>
    ep.istrazivackiRezultati.addVerzija({
      ID_IR: { ID_IR: entity.ID_IR },
      BrojVerzije: Number(values.BrojVerzije),
      DatumPostavljanja: values.DatumPostavljanja,
      OpisIzmena: values.OpisIzmena,
      OdgovornaOsoba: values.OdgovornaOsoba,
    }),
};

const fajloviRelation = {
  key: "fajlovi",
  label: "Pripadajući fajlovi",
  listKey: "PripadajuciFajlovi",
  itemLabel: (item) => `${item.NazivFajla} (v${item.BrojVerzije})`,
  addFields: [
    { key: "BrojVerzije", label: "Broj verzije", type: "number", required: true },
    { key: "NazivFajla", label: "Naziv fajla", type: "text", required: true },
  ],
  onAdd: (entity, values) =>
    ep.istrazivackiRezultati.addPripadajuciFajl({
      ID_IR: { ID_IR: entity.ID_IR },
      BrojVerzije: Number(values.BrojVerzije),
      NazivFajla: values.NazivFajla,
    }),
};

export const istrazivackiRezultatTypes = [
  {
    key: "sve",
    label: "Svi Istraživački Rezultati",
    idKey: "ID_IR",
    columns: baseIRColumns,
    capabilities: { add: false, edit: false, delete: false },
    api: { getAll: ep.istrazivackiRezultati.getAll },
    detailFields: baseIRAddFields.map(({ key, label }) => ({ key, label })),
    relations: [],
  },
  {
    key: "naucniRad",
    label: "Naučni Rad",
    idKey: "ID_IR",
    columns: [...baseIRColumns, { key: "TipRada", label: "Tip rada" }],
    capabilities: { add: true, edit: true, delete: true },
    api: {
      getAll: ep.naucniRad.getAll,
      add: (values) => ep.naucniRad.add(values),
      update: (values) => ep.naucniRad.update(values),
      remove: (row) => ep.naucniRad.remove(row.ID_IR),
    },
    addFields: [
      ...baseIRAddFields,
      { key: "TipRada", label: "Tip rada", type: "text" },
      { key: "NazivCasKon", label: "Naziv časopisa/konferencije", type: "text" },
      { key: "Doi", label: "DOI", type: "text" },
      { key: "IssnIliIsbn", label: "ISSN / ISBN", type: "text" },
      { key: "BrojSveske", label: "Broj sveske", type: "number" },
      { key: "BrojIzdanja", label: "Broj izdanja", type: "number" },
      { key: "BrojStranice", label: "Broj stranica", type: "number" },
    ],
    editFields: [
      ...baseIRAddFields,
      { key: "TipRada", label: "Tip rada", type: "text" },
      { key: "NazivCasKon", label: "Naziv časopisa/konferencije", type: "text" },
      { key: "Doi", label: "DOI", type: "text" },
      { key: "IssnIliIsbn", label: "ISSN / ISBN", type: "text" },
      { key: "BrojSveske", label: "Broj sveske", type: "number" },
      { key: "BrojIzdanja", label: "Broj izdanja", type: "number" },
      { key: "BrojStranice", label: "Broj stranica", type: "number" },
      ...baseIREditExtra,
    ],
    detailFields: [
      { key: "TipRada", label: "Tip rada" },
      { key: "NazivCasKon", label: "Naziv časopisa/konferencije" },
      { key: "Doi", label: "DOI" },
      { key: "IssnIliIsbn", label: "ISSN / ISBN" },
      { key: "BrojSveske", label: "Broj sveske" },
      { key: "BrojIzdanja", label: "Broj izdanja" },
      { key: "BrojStranice", label: "Broj stranica" },
    ],
    relations: [kljucneReciRelation, verzijeRelation, fajloviRelation],
  },
  {
    key: "knjiga",
    label: "Knjiga / Poglavlje",
    idKey: "ID_IR",
    columns: [...baseIRColumns, { key: "Izdavac", label: "Izdavač" }],
    capabilities: { add: true, edit: true, delete: true },
    api: {
      getAll: ep.knjiga.getAll,
      add: (values) => ep.knjiga.add(values),
      update: (values) => ep.knjiga.update(values),
      remove: (row) => ep.knjiga.remove(row.ID_IR),
    },
    addFields: [
      ...baseIRAddFields,
      { key: "Izdavac", label: "Izdavač", type: "text" },
      { key: "MestoIzdavanja", label: "Mesto izdavanja", type: "text" },
    ],
    editFields: [
      ...baseIRAddFields,
      { key: "Izdavac", label: "Izdavač", type: "text" },
      { key: "MestoIzdavanja", label: "Mesto izdavanja", type: "text" },
      ...baseIREditExtra,
    ],
    detailFields: [
      { key: "Izdavac", label: "Izdavač" },
      { key: "MestoIzdavanja", label: "Mesto izdavanja" },
    ],
    relations: [
      kljucneReciRelation,
      verzijeRelation,
      fajloviRelation,
      {
        key: "urednici",
        label: "Urednici",
        listKey: "Urednici",
        itemLabel: (item) =>
          `${get(item, "ID_Urednika.ID_I.Ime") || ""} ${get(item, "ID_Urednika.ID_I.Prezime") || ""}`.trim() ||
          `Urednik #${get(item, "ID_Urednika.ID_U") ?? ""}`,
        addFields: [{ key: "ID_U", label: "ID Urednika", type: "number", required: true }],
        onAdd: (entity, values) => ep.knjiga.addUrednik(Number(values.ID_U), entity.ID_IR),
        readOnlyDelete: true,
      },
    ],
  },
  {
    key: "dataset",
    label: "Dataset",
    idKey: "ID_IR",
    columns: [...baseIRColumns, { key: "Format", label: "Format" }],
    capabilities: { add: true, edit: true, delete: true },
    api: {
      getAll: ep.dataset.getAll,
      add: (values) => ep.dataset.add(values),
      update: (values) => ep.dataset.update(values),
      remove: (row) => ep.dataset.remove(row.ID_IR),
    },
    addFields: [
      ...baseIRAddFields,
      { key: "Format", label: "Format", type: "text" },
      { key: "Velicina", label: "Veličina", type: "number" },
      { key: "BrojZapisa", label: "Broj zapisa", type: "number" },
      { key: "OpisStrukture", label: "Opis strukture", type: "textarea" },
      { key: "PeriodObuhvataPodataka", label: "Period obuhvata podataka", type: "text" },
      { key: "LicencaKoriscenja", label: "Licenca korišćenja", type: "text" },
      { key: "OgranicenjaPristupa", label: "Ograničenja pristupa", type: "text" },
    ],
    editFields: [
      ...baseIRAddFields,
      { key: "Format", label: "Format", type: "text" },
      { key: "Velicina", label: "Veličina", type: "number" },
      { key: "BrojZapisa", label: "Broj zapisa", type: "number" },
      { key: "OpisStrukture", label: "Opis strukture", type: "textarea" },
      { key: "PeriodObuhvataPodataka", label: "Period obuhvata podataka", type: "text" },
      { key: "LicencaKoriscenja", label: "Licenca korišćenja", type: "text" },
      { key: "OgranicenjaPristupa", label: "Ograničenja pristupa", type: "text" },
      ...baseIREditExtra,
    ],
    detailFields: [
      { key: "Format", label: "Format" },
      { key: "Velicina", label: "Veličina" },
      { key: "BrojZapisa", label: "Broj zapisa" },
      { key: "OpisStrukture", label: "Opis strukture" },
      { key: "PeriodObuhvataPodataka", label: "Period obuhvata podataka" },
      { key: "LicencaKoriscenja", label: "Licenca korišćenja" },
      { key: "OgranicenjaPristupa", label: "Ograničenja pristupa" },
    ],
    relations: [kljucneReciRelation, verzijeRelation, fajloviRelation],
  },
  {
    key: "tehnickiIzvestaj",
    label: "Tehnički Izveštaj",
    idKey: "ID_IR",
    columns: baseIRColumns,
    capabilities: { add: true, edit: true, delete: true },
    api: {
      getAll: ep.tehnickiIzvestaj.getAll,
      add: (values) => ep.tehnickiIzvestaj.add(values),
      update: (values) => ep.tehnickiIzvestaj.update(values),
      remove: (row) => ep.tehnickiIzvestaj.remove(row.ID_IR),
    },
    addFields: baseIRAddFields,
    editFields: [...baseIRAddFields, ...baseIREditExtra],
    detailFields: [],
    relations: [kljucneReciRelation, verzijeRelation, fajloviRelation],
  },
  {
    key: "softverskiArtifakt",
    label: "Softverski Artifakt",
    idKey: "ID_IR",
    columns: [...baseIRColumns, { key: "ProgramskiJezik", label: "Jezik" }],
    capabilities: { add: true, edit: true, delete: true },
    api: {
      getAll: ep.softverskiArtifakt.getAll,
      add: (values) => ep.softverskiArtifakt.add(values),
      update: (values) => ep.softverskiArtifakt.update(values),
      remove: (row) => ep.softverskiArtifakt.remove(row.ID_IR),
    },
    addFields: [
      ...baseIRAddFields,
      { key: "ProgramskiJezik", label: "Programski jezik", type: "text", required: true },
      { key: "RepoLink", label: "Link ka repozitorijumu", type: "text", required: true },
      { key: "NacinLicenciranja", label: "Način licenciranja", type: "text", required: true },
      { key: "Dokumentacija", label: "Dokumentacija", type: "textarea", required: true },
    ],
    editFields: [
      ...baseIRAddFields,
      { key: "ProgramskiJezik", label: "Programski jezik", type: "text" },
      { key: "RepoLink", label: "Link ka repozitorijumu", type: "text" },
      { key: "NacinLicenciranja", label: "Način licenciranja", type: "text" },
      { key: "Dokumentacija", label: "Dokumentacija", type: "textarea" },
      ...baseIREditExtra,
    ],
    detailFields: [
      { key: "ProgramskiJezik", label: "Programski jezik" },
      { key: "RepoLink", label: "Link ka repozitorijumu" },
      { key: "NacinLicenciranja", label: "Način licenciranja" },
      { key: "Dokumentacija", label: "Dokumentacija" },
    ],
    relations: [
      kljucneReciRelation,
      verzijeRelation,
      fajloviRelation,
      {
        key: "platforme",
        label: "Podržane platforme",
        listKey: "PodrzanePlatforme",
        itemLabel: (item) => item.Platforma,
        addFields: [{ key: "platforma", label: "Platforma", type: "text", required: true }],
        onAdd: (entity, values) => ep.softverskiArtifakt.addPlatformu(entity.ID_IR, values.platforma),
        onDelete: (entity, item) =>
          ep.softverskiArtifakt.removePlatformu(entity.ID_IR, item.Platforma),
      },
    ],
  },
  {
    key: "ostaliDokumenti",
    label: "Ostali Dokumenti",
    idKey: "ID_IR",
    columns: [...baseIRColumns, { key: "Opcije", label: "Vrsta" }],
    capabilities: { add: true, edit: true, delete: true },
    api: {
      getAll: ep.ostaliDokumenti.getAll,
      add: (values) => ep.ostaliDokumenti.add(values),
      update: (values) => ep.ostaliDokumenti.update(values),
      remove: (row) => ep.ostaliDokumenti.remove(row.ID_IR),
    },
    addFields: [...baseIRAddFields, { key: "Opcije", label: "Vrsta dokumenta", type: "text" }],
    editFields: [
      ...baseIRAddFields,
      { key: "Opcije", label: "Vrsta dokumenta", type: "text" },
      ...baseIREditExtra,
    ],
    detailFields: [{ key: "Opcije", label: "Vrsta dokumenta" }],
    relations: [kljucneReciRelation, verzijeRelation, fajloviRelation],
  },
];

/* ============================================================
   ISTRAŽIVAČI I NJIHOVE ULOGE
   ============================================================ */

const istrazivacColumns = [
  { key: "ID_I", label: "ID" },
  { key: "Ime", label: "Ime" },
  { key: "Prezime", label: "Prezime" },
  { key: "NaucnaOblast", label: "Naučna oblast" },
  { key: "NaucnoZvanje", label: "Zvanje" },
];

const istrazivacAddFields = [
  { key: "Ime", label: "Ime", type: "text", required: true },
  { key: "Prezime", label: "Prezime", type: "text", required: true },
  { key: "DatumRodjenja", label: "Datum rođenja", type: "date" },
  { key: "Drzava", label: "Država", type: "text" },
  { key: "NaucnaOblast", label: "Naučna oblast", type: "text" },
  { key: "NaucnoZvanje", label: "Naučno zvanje", type: "text" },
  {
    key: "StatusNaucnika",
    label: "Status naučnika",
    type: "select",
    required: true,
    defaultValue: "AKTIVAN",
    options: [
      { value: "AKTIVAN", label: "Aktivan" },
      { value: "NEAKTIVAN", label: "Neaktivan" },
    ],
  },
];

const mailRelation = (getId, addFn, removeFn) => ({
  key: "mailovi",
  label: "Mail adrese",
  listKey: "Mailovi",
  itemLabel: (item) => item.MailAdresa,
  addFields: [{ key: "mail", label: "Mail adresa", type: "text", required: true }],
  onAdd: (entity, values) => addFn(getId(entity), values.mail),
  onDelete: (entity, item) => removeFn(getId(entity), item.MailAdresa),
});

const telefonRelation = (getId, addFn, removeFn) => ({
  key: "telefoni",
  label: "Telefoni",
  listKey: "Telefoni",
  itemLabel: (item) => item.Broj,
  addFields: [{ key: "broj", label: "Broj telefona", type: "text", required: true }],
  onAdd: (entity, values) => addFn(getId(entity), values.broj),
  onDelete: (entity, item) => removeFn(getId(entity), item.Broj),
});

const ulogeRelation = {
  key: "uloge",
  label: "Uloge",
  listKey: "Uloge",
  itemLabel: (item) => `${item.NazivUloge || "Uloga"} (#${item.ID_U})`,
  readOnlyDelete: true,
};

const researcherSelectField = () => ({
  key: "ID_I",
  label: "Istraživač",
  type: "select",
  required: true,
  loadOptions: () => ep.istrazivaci.getAll().then((istrazivaci) =>
    istrazivaci.map((istrazivac) => ({
      value: istrazivac.ID_I,
      label: `${istrazivac.Ime} ${istrazivac.Prezime} (#${istrazivac.ID_I})`,
    }))
  ),
});

const reviewerSelectField = () => ({
  key: "ID_Recenzenta",
  label: "Recenzent",
  type: "select",
  required: true,
  loadOptions: () => ep.recenzent.getAll().then((recenzenti) =>
    recenzenti.map((recenzent) => ({
      value: recenzent.ID_U,
      label: `${get(recenzent, "ID_I.Ime") || ""} ${get(recenzent, "ID_I.Prezime") || ""} (#${recenzent.ID_U})`.trim(),
    }))
  ),
});

const editorSelectField = () => ({
  key: "ID_Urednika",
  label: "Urednik",
  type: "select",
  required: true,
  loadOptions: () => ep.urednik.getAll().then((urednici) =>
    urednici.map((urednik) => ({
      value: urednik.ID_U,
      label: `${get(urednik, "ID_I.Ime") || ""} ${get(urednik, "ID_I.Prezime") || ""} (#${urednik.ID_U})`.trim(),
    }))
  ),
});

const institucijeRelation = {
  key: "institucije",
  label: "Angažovanja u institucijama",
  listKey: "Institucije",
  itemLabel: (item) =>
    `${get(item, "ID_NII.Naziv") || ""} — ${item.NazivPozicije || ""} (${fmtDate(item.DatumAngazovanja)})`,
  addFields: [
    {
      key: "ID_NII",
      label: "Institucija",
      type: "select",
      required: true,
      loadOptions: () => ep.institucije.getAll().then((institucije) =>
        institucije.map((institucija) => ({ value: institucija.ID_NII, label: `${institucija.Naziv} (#${institucija.ID_NII})` }))
      ),
    },
    { key: "DatumAngazovanja", label: "Datum angažovanja", type: "date", required: true },
    { key: "DatumZavrsetka", label: "Datum završetka", type: "date" },
    { key: "OrganizacionaJedinica", label: "Organizaciona jedinica", type: "text" },
    { key: "NazivPozicije", label: "Naziv pozicije", type: "text" },
    { key: "TipAngazovanja", label: "Tip angažovanja", type: "text" },
  ],
  onAdd: (entity, values) =>
    ep.istrazivaci.angazuj({
      ID_I: { ID_I: entity.ID_I },
      ID_NII: { ID_NII: Number(values.ID_NII) },
      DatumAngazovanja: values.DatumAngazovanja,
      DatumZavrsetka: values.DatumZavrsetka || null,
      OrganizacionaJedinica: values.OrganizacionaJedinica,
      NazivPozicije: values.NazivPozicije,
      TipAngazovanja: values.TipAngazovanja,
    }),
  readOnlyDelete: true,
};

export const istrazivacTypes = [
  {
    key: "sve",
    label: "Svi Istraživači",
    idKey: "ID_I",
    columns: istrazivacColumns,
    capabilities: { add: true, edit: true, delete: false },
    api: {
      getAll: ep.istrazivaci.getAll,
      add: ep.istrazivaci.add,
      update: ep.istrazivaci.update,
    },
    addFields: istrazivacAddFields,
    editFields: [...istrazivacAddFields, { key: "ID_I", type: "hidden" }],
    detailFields: istrazivacAddFields.map(({ key, label }) => ({ key, label })),
    relations: [
      mailRelation((e) => e.ID_I, ep.istrazivaci.addMail, ep.istrazivaci.removeMail),
      telefonRelation((e) => e.ID_I, ep.istrazivaci.addTelefon, ep.istrazivaci.removeTelefon),
      ulogeRelation,
      institucijeRelation,
    ],
  },
  {
    key: "autor",
    label: "Autori",
    idKey: "ID_I.ID_I",
    columns: [
      { key: "ID_U", label: "ID uloge" },
      { key: "ID_I.ID_I", label: "ID" },
      { key: "ID_I.Ime", label: "Ime" },
      { key: "ID_I.Prezime", label: "Prezime" },
      { key: "Orcid", label: "ORCID" },
    ],
    capabilities: { add: true, edit: false, delete: true },
    api: {
      getAll: ep.autor.getAll,
      add: (v) => ep.autor.add(v.ID_I, v.Orcid),
      remove: (row) => ep.autor.remove(row.ID_U),
    },
    addFields: [
      researcherSelectField(),
      {
        key: "Orcid",
        label: "ORCID",
        type: "text",
        required: true,
        pattern: "[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{3}[0-9Xx]",
        title: "ORCID mora biti u formatu 0000-0000-0000-000X",
        placeholder: "0000-0000-0000-000X",
      },
    ],
    detailFields: [{ key: "Orcid", label: "ORCID" }],
    relations: [],
  },
  {
    key: "recenzent",
    label: "Recenzenti",
    idKey: "ID_I.ID_I",
    columns: [
      { key: "ID_U", label: "ID uloge" },
      { key: "ID_I.ID_I", label: "ID" },
      { key: "ID_I.Ime", label: "Ime" },
      { key: "ID_I.Prezime", label: "Prezime" },
    ],
    capabilities: { add: true, edit: false, delete: true },
    api: {
      getAll: ep.recenzent.getAll,
      add: (v) => ep.recenzent.add(v.ID_I),
      remove: (row) => ep.recenzent.remove(row.ID_U),
    },
    addFields: [researcherSelectField()],
    detailFields: [],
    relations: [
      {
        key: "oblasti",
        label: "Oblasti ekspertize",
        listKey: "OblastiEkspertize",
        itemLabel: (item) => item.Oblast,
        addFields: [{ key: "oblast", label: "Oblast ekspertize", type: "text", required: true }],
        onAdd: (entity, values) => ep.recenzent.addOblastEkspertize(entity.ID_U, values.oblast),
        onDelete: (entity, item) => ep.recenzent.removeOblastEkspertize(entity.ID_U, item.Oblast),
      },
    ],
  },
  {
    key: "urednik",
    label: "Urednici",
    idKey: "ID_I.ID_I",
    columns: [
      { key: "ID_U", label: "ID uloge" },
      { key: "ID_I.ID_I", label: "ID" },
      { key: "ID_I.Ime", label: "Ime" },
      { key: "ID_I.Prezime", label: "Prezime" },
      { key: "UredjivackaSekcija", label: "Uređivačka sekcija" },
    ],
    capabilities: { add: true, edit: false, delete: true },
    api: {
      getAll: ep.urednik.getAll,
      add: (v) => ep.urednik.add(v.ID_I, v.UredjivackaSekcija),
      remove: (row) => ep.urednik.remove(row.ID_U),
    },
    addFields: [
      researcherSelectField(),
      { key: "UredjivackaSekcija", label: "Uređivačka sekcija", type: "text", required: true },
    ],
    detailFields: [{ key: "UredjivackaSekcija", label: "Uređivačka sekcija" }],
    relations: [],
  },
  {
    key: "rukovodilac",
    label: "Rukovodioci Projekta",
    idKey: "ID_I.ID_I",
    columns: [
      { key: "ID_U", label: "ID uloge" },
      { key: "ID_I.ID_I", label: "ID" },
      { key: "ID_I.Ime", label: "Ime" },
      { key: "ID_I.Prezime", label: "Prezime" },
    ],
    capabilities: { add: true, edit: false, delete: true },
    api: {
      getAll: ep.rukovodilac.getAll,
      add: (v) => ep.rukovodilac.add(v.ID_I),
      remove: (row) => ep.rukovodilac.remove(row.ID_U),
    },
    addFields: [researcherSelectField()],
    detailFields: [],
    relations: [],
  },
  {
    key: "administrator",
    label: "Administratori Repozitorijuma",
    idKey: "ID_I.ID_I",
    columns: [
      { key: "ID_U", label: "ID uloge" },
      { key: "ID_I.ID_I", label: "ID" },
      { key: "ID_I.Ime", label: "Ime" },
      { key: "ID_I.Prezime", label: "Prezime" },
    ],
    capabilities: { add: true, edit: false, delete: true },
    api: {
      getAll: ep.administrator.getAll,
      add: (v) => ep.administrator.add(v.ID_I),
      remove: (row) => ep.administrator.remove(row.ID_U),
    },
    addFields: [researcherSelectField()],
    detailFields: [],
    relations: [
      {
        key: "ovlascenja",
        label: "Ovlašćenja",
        listKey: "Ovlascenja",
        itemLabel: (item) => item.Ovlascenje,
        addFields: [{ key: "ovlascenje", label: "Ovlašćenje", type: "text", required: true }],
        onAdd: (entity, values) => ep.administrator.addOvlascenje(entity.ID_U, values.ovlascenje),
        onDelete: (entity, item) =>
          ep.administrator.removeOvlascenje({ ID_U: { ID_U: entity.ID_U }, Ovlascenje: item.Ovlascenje }),
      },
    ],
  },
];

/* ============================================================
   NAUČNO ISTRAŽIVAČKE INSTITUCIJE
   ============================================================ */

export const institucijaType = {
  key: "institucija",
  label: "Naučno Istraživačke Institucije",
  idKey: "ID_NII",
  columns: [
    { key: "ID_NII", label: "ID" },
    { key: "Naziv", label: "Naziv" },
    { key: "Adresa", label: "Adresa" },
  ],
  capabilities: { add: true, edit: true, delete: true },
  api: {
    getAll: ep.institucije.getAll,
    add: ep.institucije.add,
    update: ep.institucije.update,
    remove: (row) => ep.institucije.remove(row.ID_NII),
  },
  addFields: [
    { key: "Naziv", label: "Naziv", type: "text", required: true },
    { key: "Adresa", label: "Adresa", type: "text" },
  ],
  editFields: [
    { key: "Naziv", label: "Naziv", type: "text", required: true },
    { key: "Adresa", label: "Adresa", type: "text" },
    { key: "ID_NII", type: "hidden" },
  ],
  detailFields: [{ key: "Naziv", label: "Naziv" }, { key: "Adresa", label: "Adresa" }],
  relations: [
    mailRelation((e) => e.ID_NII, ep.institucije.addMail, ep.institucije.removeMail),
    telefonRelation((e) => e.ID_NII, ep.institucije.addTelefon, ep.institucije.removeTelefon),
    {
      key: "oblasti",
      label: "Naučne oblasti",
      listKey: "NaucneOblasti",
      itemLabel: (item) => item.Oblast,
      addFields: [{ key: "oblast", label: "Naučna oblast", type: "text", required: true }],
      onAdd: (entity, values) => ep.institucije.addOblast(entity.ID_NII, values.oblast),
      readOnlyDelete: true,
    },
    {
      key: "angazovani",
      label: "Angažovani istraživači",
      listKey: "Angazovani",
      itemLabel: (item) =>
        `${get(item, "ID_I.Ime") || ""} ${get(item, "ID_I.Prezime") || ""} — ${item.NazivPozicije || ""}`.trim(),
      addFields: null,
      readOnlyDelete: true,
    },
  ],
};

/* ============================================================
   PUBLIKACIJE
   ============================================================ */

export const publikacijaType = {
  key: "publikacija",
  label: "Publikacije",
  idKey: "ID_P",
  columns: [
    { key: "ID_P", label: "ID" },
    {
      key: "vrsta",
      label: "Vrsta",
      render: (row) => (row.ID_D ? "Dataset" : row.ID_TI ? "Tehnički izveštaj" : row.ID_SA ? "Softverski artifakt" : "—"),
    },
    { key: "Autorstva", label: "Broj autora", render: (row) => (row.Autorstva || []).length },
  ],
  capabilities: { add: true, edit: false, delete: false },
  api: {
    getAll: ep.publikacije.getAll,
    add: (v) => ep.publikacije.add(Number(v.ID_U), Number(v.RedniBroj), v.Doprinos, v.Uloga),
  },
  addFields: [
    {
      key: "ID_U",
      label: "Autor",
      type: "select",
      required: true,
      loadOptions: () => ep.autor.getAll().then((autori) =>
        autori.map((autor) => ({
          value: autor.ID_U,
          label: `${get(autor, "ID_I.Ime") || ""} ${get(autor, "ID_I.Prezime") || ""} (#${autor.ID_U})`.trim(),
        }))
      ),
    },
    { key: "RedniBroj", label: "Redni broj autora", type: "number", required: true },
    { key: "Doprinos", label: "Tip doprinosa", type: "text" },
    { key: "Uloga", label: "Uloga u publikaciji", type: "text" },
  ],
  detailFields: [],
  relations: [
    {
      key: "dataset",
      label: "Dataset",
      listKey: "ID_D",
      itemLabel: (item) => `#${item.ID_IR}${item.Naziv ? ` — ${item.Naziv}` : ""}`,
      addFields: [
        {
          key: "ID_D",
          label: "Dataset",
          type: "select",
          required: true,
          loadOptions: () => ep.dataset.getAll().then((datasets) =>
            datasets.map((dataset) => ({
              value: dataset.ID_IR,
              label: `#${dataset.ID_IR}${dataset.Naziv ? ` — ${dataset.Naziv}` : ""}`,
            }))
          ),
        },
      ],
      onAdd: (entity, values) => ep.publikacije.addDataset(Number(values.ID_D), entity.ID_P),
      readOnlyDelete: true,
    },
    {
      key: "tehnickiIzvestaj",
      label: "Tehnički izveštaj",
      listKey: "ID_TI",
      itemLabel: (item) => `#${item.ID_IR}${item.Naziv ? ` — ${item.Naziv}` : ""}`,
      addFields: [
        {
          key: "ID_TI",
          label: "Tehnički izveštaj",
          type: "select",
          required: true,
          loadOptions: () => ep.tehnickiIzvestaj.getAll().then((izvestaji) =>
            izvestaji.map((izvestaj) => ({
              value: izvestaj.ID_IR,
              label: `#${izvestaj.ID_IR}${izvestaj.Naziv ? ` — ${izvestaj.Naziv}` : ""}`,
            }))
          ),
        },
      ],
      onAdd: (entity, values) =>
        ep.publikacije.addTehnickiIzvestaj(Number(values.ID_TI), entity.ID_P),
      readOnlyDelete: true,
    },
    {
      key: "softverskiArtifakt",
      label: "Softverski artifakt",
      listKey: "ID_SA",
      itemLabel: (item) => `#${item.ID_IR}${item.Naziv ? ` — ${item.Naziv}` : ""}`,
      addFields: [
        {
          key: "ID_SA",
          label: "Softverski artifakt",
          type: "select",
          required: true,
          loadOptions: () => ep.softverskiArtifakt.getAll().then((artifakti) =>
            artifakti.map((artifakt) => ({
              value: artifakt.ID_IR,
              label: `#${artifakt.ID_IR}${artifakt.Naziv ? ` — ${artifakt.Naziv}` : ""}`,
            }))
          ),
        },
      ],
      onAdd: (entity, values) =>
        ep.publikacije.addSoftverskiArtifakt(Number(values.ID_SA), entity.ID_P),
      readOnlyDelete: true,
    },
    {
      key: "autorstva",
      label: "Autorstva",
      listKey: "Autorstva",
      itemLabel: (item) =>
        `${get(item, "ID_U.ID_I.Ime") || ""} ${get(item, "ID_U.ID_I.Prezime") || ""} (#${item.RedniBrojAutora})`,
      addFields: [
        {
          key: "ID_U",
          label: "Autor",
          type: "select",
          required: true,
          loadOptions: () => ep.autor.getAll().then((autori) =>
            autori.map((autor) => ({
              value: autor.ID_U,
              label: `${get(autor, "ID_I.Ime") || ""} ${get(autor, "ID_I.Prezime") || ""} (#${autor.ID_U})`.trim(),
            }))
          ),
        },
        { key: "RedniBrojAutora", label: "Redni broj autora", type: "number", required: true },
        { key: "TipDoprinosa", label: "Tip doprinosa", type: "text" },
        { key: "UlogaUPublikaciji", label: "Uloga u publikaciji", type: "text" },
      ],
      onAdd: (entity, values) =>
        ep.publikacije.addAutorstvo({
          ID_U: Number(values.ID_U),
          ID_P: entity.ID_P,
          RedniBrojAutora: Number(values.RedniBrojAutora),
          TipDoprinosa: values.TipDoprinosa,
          UlogaUPublikaciji: values.UlogaUPublikaciji,
        }),
      readOnlyDelete: true,
    },
    {
      key: "runde",
      label: "Runde recenzije",
      listKey: "RundeRecenzije",
      itemLabel: (item) => `Runda ${item.BrojRunde} — ${item.KonacnaOdluka || "u toku"}`,
      addFields: [
        reviewerSelectField(),
        editorSelectField(),
        { key: "BrojRunde", label: "Broj runde", type: "number", required: true },
        {
          key: "Preporuka",
          label: "Preporuka recenzenta",
          type: "select",
          required: true,
          options: PREPORUKA_OPTIONS,
        },
        { key: "DatumOdluke", label: "Datum odluke", type: "date", required: true },
        {
          key: "KonacnaOdluka",
          label: "Konačna odluka",
          type: "select",
          required: true,
          options: KONACNA_ODLUKA_OPTIONS,
        },
      ],
      onAdd: (entity, values) =>
        ep.rundeRecenzije.add({
          ID_Recenzenta: Number(values.ID_Recenzenta),
          ID_Urednika: Number(values.ID_Urednika),
          ID_Publikacija: entity.ID_P,
          BrojRunde: Number(values.BrojRunde),
          Preporuka: values.Preporuka,
          DatumOdluke: values.DatumOdluke,
          KonacnaOdluka: values.KonacnaOdluka,
        }),
      readOnlyDelete: true,
    },
    {
      key: "citirajuce",
      label: "Citira publikacije",
      listKey: "CitirajucePublikacije",
      itemLabel: (item) => `→ ${get(item, "ID_P2.ID_P")} (${item.TipCitata || ""})`,
      addFields: [
        { key: "ID_P2", label: "ID citirane publikacije", type: "number", required: true },
        {
          key: "tip",
          label: "Tip citata",
          type: "select",
          required: true,
          options: [
            { value: "DIREKTAN", label: "Direktan" },
            { value: "INDIREKTAN", label: "Indirektan" },
          ],
        },
        { key: "mesto", label: "Mesto citiranja", type: "text" },
        { key: "kontekst", label: "Kontekst citiranja", type: "textarea" },
      ],
      onAdd: (entity, values) =>
        ep.publikacije.addCitat(entity.ID_P, Number(values.ID_P2), values.tip, values.mesto, values.kontekst),
      readOnlyDelete: true,
    },
    {
      key: "citirane",
      label: "Citiraju ovu publikaciju",
      listKey: "CitiranePublikacije",
      itemLabel: (item) => `← ${get(item, "ID_P1.ID_P")} (${item.TipCitata || ""})`,
      addFields: [
        { key: "ID_P1", label: "ID citirajuće publikacije", type: "number", required: true },
        {
          key: "tip",
          label: "Tip citata",
          type: "select",
          required: true,
          options: [
            { value: "DIREKTAN", label: "Direktan" },
            { value: "INDIREKTAN", label: "Indirektan" },
          ],
        },
        { key: "mesto", label: "Mesto citiranja", type: "text" },
        { key: "kontekst", label: "Kontekst citiranja", type: "textarea" },
      ],
      onAdd: (entity, values) =>
        ep.publikacije.addCitat(Number(values.ID_P1), entity.ID_P, values.tip, values.mesto, values.kontekst),
      readOnlyDelete: true,
    },
  ],
};
