import { api } from "./client";

/* ---------------- Naučno Istraživačke Institucije ---------------- */
export const institucije = {
  getAll: () => api.get("NaucneII/PreuzmiInstitucije"),
  add: (n) => api.post("NaucneII/DodajNaucnoIstrazivackuInstituciju", n),
  update: (n) => api.put("NaucneII/PromeniNaucnoIstrazivackuInstituciju", n),
  remove: (id) => api.del(`NaucneII/ObrisiNaucnoIstrazivackuInstituciju/${id}`),
  addMail: (idNii, mail) =>
    api.post(`NaucneII/DodajMailInstituciji/${idNii}/${encodeURIComponent(mail)}`),
  removeMail: (idNii, mail) =>
    api.del(`NaucneII/ObrisiMailInstitucije/${idNii},${encodeURIComponent(mail)}`),
  addTelefon: (idNii, phone) =>
    api.post(`NaucneII/DodajTelefonInstituciji/${idNii}/${encodeURIComponent(phone)}`),
  removeTelefon: (idNii, broj) =>
    api.del(`NaucneII/ObrisiTelefonInstitucije/${idNii}?broj=${encodeURIComponent(broj)}`),
  addOblast: (idNii, oblast) =>
    api.post(`NaucneII/DodajNaucnuOblastNaucnojInstituciji/${idNii}/${encodeURIComponent(oblast)}`),
};

/* ---------------- Istraživači ---------------- */
export const istrazivaci = {
  getAll: () => api.get("Istrazivac/PreuzmiSveIstrazivace"),
  getOne: (idI) => api.get("Istrazivac/PreuzmiIstrazivaca", { ID_I: idI }),
  add: (i) => api.post("Istrazivac/DodajIstrazivaca", i),
  update: (i) => api.put("Istrazivac/AzurirajIstrazivaca", i),
  addMail: (idI, mail) =>
    api.post(`Istrazivac/DodajMailIstrazivacu/${idI}/${encodeURIComponent(mail)}`),
  removeMail: (idI, mail) =>
    api.del(`Istrazivac/ObrisiMailIstrazivaca/${idI},${encodeURIComponent(mail)}`),
  addTelefon: (idI, phone) =>
    api.post(`Istrazivac/DodajTelefonIstrazivacu/${idI}/${encodeURIComponent(phone)}`),
  removeTelefon: (idI, broj) =>
    api.del(`Istrazivac/ObrisiTelefonIstrazivac/${idI}?broj=${encodeURIComponent(broj)}`),
  angazuj: (angazovanje) => api.post("Istrazivac/AngazujIstrazivacaUInstitut", angazovanje),
};

export const uloge = {
  getSveZaIstrazivaca: (idI) => api.get("Uloga/VratiUloge", { ID_I: idI }),
};

export const autor = {
  getAll: () => api.get("UlogaAutor/VratiSveAutore"),
  getOne: (idI) => api.get(`UlogaAutor/VratiAutora/${idI}`),
  add: (idI, orcid) => api.post(`UlogaAutor/DodajAutora/${idI}/${encodeURIComponent(orcid || "")}`),
  remove: (idI) => api.del(`UlogaAutor/ObrisiAutora/${idI}`),
};

export const recenzent = {
  getAll: () => api.get("UlogaRecenzent/VratiSveRecenzente"),
  getOne: (idI) => api.get(`UlogaRecenzent/VratiRecenzenta/${idI}`),
  add: (idI) => api.post(`UlogaRecenzent/DodajRecenzenta/${idI}`),
  remove: (idI) => api.del(`UlogaRecenzent/ObrisiRecenzenta/${idI}`),
  addOblastEkspertize: (idU, oblast) =>
    api.post(`UlogaRecenzent/DodajOblastEkspertize/${idU}/${encodeURIComponent(oblast)}`),
  removeOblastEkspertize: (idU, oblast) =>
    api.del(`UlogaRecenzent/ObrisiOblastEkspertize/${idU}?oblast=${encodeURIComponent(oblast)}`),
};

export const urednik = {
  getAll: () => api.get("UlogaUrednik/VratiSveIstrazivaceUrednike"),
  getOne: (idI) => api.get(`UlogaUrednik/VratiUrednika/${idI}`),
  add: (idI, sekcija) =>
    api.post(`UlogaUrednik/DodajUrednika/${idI}/${encodeURIComponent(sekcija)}`),
  remove: (idI) => api.del(`UlogaUrednik/ObrisiUrednika/${idI}`),
};

export const rukovodilac = {
  getAll: () => api.get("UlogaRukovodilac/VratiSveIstrazivaceRukovodioce"),
  getOne: (idI) => api.get(`UlogaRukovodilac/VratiUloguRukovodilacProjekta/${idI}`),
  add: (idI) => api.post(`UlogaRukovodilac/DodajUloguRukovodilacProjekta/${idI}`),
  remove: (idI) => api.del(`UlogaRukovodilac/ObrisiUloguRukovodilacProjekta/${idI}`),
};

export const administrator = {
  getAll: () => api.get("UlogaAdministrator/VratiSveIstrazivaceAdministratore"),
  getOne: (idI) => api.get(`UlogaAdministrator/VratiAdministatoraRepozitorijuma/${idI}`),
  add: (idI) => api.post(`UlogaAdministrator/DodajUloguAdministratorRepozitorijuma/${idI}`),
  remove: (idI) => api.del(`UlogaAdministrator/ObrisiAdministatoraRepozitorijuma/${idI}`),
  addOvlascenje: (idU, ovlascenje) =>
    api.post(`UlogaAdministrator/DodajAdministratorskaOvlascenja/${idU}/${encodeURIComponent(ovlascenje)}`),
  removeOvlascenje: (administratorOvlascenjaView) =>
    api.del("UlogaAdministrator/ObrisiAdministratorskaOvlascenja", administratorOvlascenjaView),
};

/* ---------------- Istraživački Rezultati (zajedničko) ---------------- */
export const istrazivackiRezultati = {
  getAll: () => api.get("IstrazivackiRezultat/VratiIstrazivackeRezultate"),
  addKljucnaRec: (idIr, rec) =>
    api.post(`IstrazivackiRezultat/DodajKljucneReci/${idIr}/${encodeURIComponent(rec)}`),
  removeKljucnaRec: (idIr, rec) =>
    api.del(`IstrazivackiRezultat/ObrisiKljucnuRec/${idIr}/${encodeURIComponent(rec)}`),
  addVerzija: (verzijaView) => api.post("IstrazivackiRezultat/DodajVerzijuIR", verzijaView),
  addPripadajuciFajl: (fajlView) =>
    api.post("IstrazivackiRezultat/DodajPripadajuciFajl", fajlView),
};

export const naucniRad = {
  getAll: () => api.get("IRNaucniRadovi/VratiSveNaucniRadove"),
  getOne: (idIr) => api.get(`IRNaucniRadovi/VratiNaucniRad/${idIr}`),
  add: (dto) => api.post("IRNaucniRadovi/DodajNaucniRad", dto),
  update: (view) => api.put("IRNaucniRadovi/AzurirajNaucniRad", view),
  remove: (idIr) => api.del(`IRNaucniRadovi/ObrisiNaucniRad/${idIr}`),
};

export const knjiga = {
  getAll: () => api.get("IRKnjigeIliPoglavlja/VratiSveKnjigeIliPoglavlje"),
  getOne: (idIr) => api.get(`IRKnjigeIliPoglavlja/VratiKnjigeIliPoglavlje/${idIr}`),
  add: (dto) => api.post("IRKnjigeIliPoglavlja/DodajKnjigeIliPoglavlje", dto),
  update: (view) => api.put("IRKnjigeIliPoglavlja/AzurirajKnjigeIliPoglavlje", view),
  remove: (idIr) => api.del(`IRKnjigeIliPoglavlja/ObrisiKnjigeIliPoglavlje/${idIr}`),
  addUrednik: (idU, idIr) => api.post(`IRKnjigeIliPoglavlja/DodajUrednikaKnjizi/${idU}/${idIr}`),
};

export const dataset = {
  getAll: () => api.get("IRDataset/VratiSveDataset"),
  getOne: (idIr) => api.get(`IRDataset/VratiDataset/${idIr}`),
  add: (dto) => api.post("IRDataset/DodajDataset", dto),
  update: (view) => api.put("IRDataset/AzurirajDataset", view),
  remove: (idIr) => api.del(`IRDataset/ObrisiDataset/${idIr}`),
};

export const tehnickiIzvestaj = {
  getAll: () => api.get("IRTehnickiIzvestaj/VratiSveTehnickiIzvestaje"),
  getOne: (idIr) => api.get(`IRTehnickiIzvestaj/VratiTehnickiIzvestaj/${idIr}`),
  add: (dto) => api.post("IRTehnickiIzvestaj/DodajTehnickiIzvestaj", dto),
  update: (view) => api.put("IRTehnickiIzvestaj/AzurirajTehnickiIzvestaj", view),
  remove: (idIr) => api.del(`IRTehnickiIzvestaj/ObrisiTehnickiIzvestaj/${idIr}`),
};

export const softverskiArtifakt = {
  getAll: () => api.get("IRSoftverskiArtifakt/VratiSveSoftverskeArtifakte"),
  getOne: (idIr) => api.get(`IRSoftverskiArtifakt/VratiSoftverskiArtifakt/${idIr}`),
  add: (dto) => api.post("IRSoftverskiArtifakt/DodajSoftverskiArtifakt", dto),
  update: (view) => api.put("IRSoftverskiArtifakt/AzurirajSoftverskiArtifakt", view),
  remove: (idIr) => api.del(`IRSoftverskiArtifakt/ObrisiSoftverskiArtifakt/${idIr}`),
  addPlatformu: (idIr, platforma) =>
    api.post(`IRSoftverskiArtifakt/DodajPodrzanuPlatformu/${idIr}/${encodeURIComponent(platforma)}`),
  removePlatformu: (idIr, platforma) =>
    api.del(`IRSoftverskiArtifakt/ObrisiPodrzanuPlatformu/${idIr}/${encodeURIComponent(platforma)}`),
};

export const ostaliDokumenti = {
  getAll: () => api.get("IROstaliDokumenti/VratiSveOstaliDokument"),
  getOne: (idIr) => api.get(`IROstaliDokumenti/VratiOstaliDokument/${idIr}`),
  add: (dto) => api.post("IROstaliDokumenti/DodajOstaliDokument", dto),
  update: (view) => api.put("IROstaliDokumenti/AzurirajOstaliDokument", view),
  remove: (idIr) => api.del(`IROstaliDokumenti/ObrisiOstaliDokument/${idIr}`),
};

/* ---------------- Publikacije ---------------- */
export const publikacije = {
  getAll: () => api.get("Publikacija/VratiSvePublikacije"),
  getOne: (idP) => api.get(`Publikacija/VratiPublikaciju/${idP}`),
  add: (idU, redniBroj, doprinos, uloga) =>
    api.post("Publikacija/DodajPublikaciju", null, {
      ID_U: idU,
      redni_broj: redniBroj,
      doprinos,
      uloga,
    }),
  addAutorstvo: (dto) => api.post("Publikacija/DodajAutorstvoPublikaciji", dto),
  addDataset: (idD, idP) =>
    api.post("Publikacija/DodajDatasetPublikaciji", null, { ID_D: idD, ID_P: idP }),
  addTehnickiIzvestaj: (idTi, idP) =>
    api.post("Publikacija/DodajTehnickiIzvestajPublikacijia", null, { ID_TI: idTi, ID_P: idP }),
  addSoftverskiArtifakt: (idSa, idP) =>
    api.post("Publikacija/DodajSoftverskiArtifakt", null, { ID_SA: idSa, ID_P: idP }),
  addCitat: (idP1, idP2, tip, mesto, kontekst) =>
    api.post("Publikacija/DodajCitat", null, {
      ID_P1: idP1,
      ID_P2: idP2,
      tip,
      mesto,
      kontekst,
    }),
};

export const rundeRecenzije = {
  add: (dto) => api.post("RundaRecenzije/DodajRunduRecenzije", dto),
  addAngazovanogRecenzenta: (view) =>
    api.post("RundaRecenzije/DodajAngazovaneRecenzente", view),
  addOcenu: (idAr, ocena) =>
    api.post("RundaRecenzije/DodajOcenaAngazovanomRecenzentu", null, {
      ID_AR: idAr,
      ocena,
    }),
};
