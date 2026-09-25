
-------------------------------------------------------------------------------------------
-- Brisanje tabela
DROP TABLE UREDJUJE CASCADE CONSTRAINTS;
DROP TABLE OCENA_RECENZENTA CASCADE CONSTRAINTS;
DROP TABLE ANGAZOVANJE_RECENZENT CASCADE CONSTRAINTS;
DROP TABLE RUNDA_RECENZIJE CASCADE CONSTRAINTS;
DROP TABLE AUTORSTVO CASCADE CONSTRAINTS;
DROP TABLE CITAT CASCADE CONSTRAINTS;
DROP TABLE PUBLIKACIJA CASCADE CONSTRAINTS;
DROP TABLE ANGAZOVANJE CASCADE CONSTRAINTS;
DROP TABLE TELEFON_INSTITUCIJA CASCADE CONSTRAINTS;
DROP TABLE MAIL_INSTITUCIJA CASCADE CONSTRAINTS;
DROP TABLE NAUCNA_OBLAST CASCADE CONSTRAINTS;
DROP TABLE NI_INSTITUCIJA CASCADE CONSTRAINTS;
DROP TABLE TELEFON CASCADE CONSTRAINTS;
DROP TABLE MAIL CASCADE CONSTRAINTS;
DROP TABLE ISTRAZIVAC CASCADE CONSTRAINTS;
DROP TABLE AUTOR CASCADE CONSTRAINTS;
DROP TABLE OBLASTI_EKSPERTIZE CASCADE CONSTRAINTS;
DROP TABLE RECENZENT CASCADE CONSTRAINTS;
DROP TABLE UREDNIK CASCADE CONSTRAINTS;
DROP TABLE ADMINISTRATOR_OVLASCENJA CASCADE CONSTRAINTS;
DROP TABLE ADMINISTRATOR_REPOZITORIJUMA CASCADE CONSTRAINTS;
DROP TABLE RUKOVODILAC_PROJEKTA CASCADE CONSTRAINTS;
DROP TABLE ULOGA CASCADE CONSTRAINTS;
DROP TABLE DATASET CASCADE CONSTRAINTS;
DROP TABLE PODRZANE_PLATFORME CASCADE CONSTRAINTS;
DROP TABLE SOFTVERSKI_ARTIFAKT CASCADE CONSTRAINTS;
DROP TABLE TEHNICKI_IZVESTAJ CASCADE CONSTRAINTS;
DROP TABLE KNJIGA_ILI_POGLAVLJA CASCADE CONSTRAINTS;
DROP TABLE NAUCNI_RAD CASCADE CONSTRAINTS;
DROP TABLE OSTALI_DOKUMENTI CASCADE CONSTRAINTS;
DROP TABLE PRIPADAJUCI_FAJLOVI CASCADE CONSTRAINTS;
DROP TABLE VERZIJA CASCADE CONSTRAINTS;
DROP TABLE KLJUCNE_RECI CASCADE CONSTRAINTS;
DROP TABLE ISTRAZIVACKI_REZULTAT CASCADE CONSTRAINTS;

-------------------------------------------------------------------------------------------
-- Brisanje sekvenci
DROP SEQUENCE SEQ_ISTRAZIVACKI_REZULTAT; 
DROP SEQUENCE SEQ_ISTRAZIVAC;
DROP SEQUENCE SEQ_ULOGA; 
DROP SEQUENCE SEQ_NI_INSTITUCIJA; 
DROP SEQUENCE SEQ_PUBLIKACIJA; 
DROP SEQUENCE SEQ_OCENA_RECENZENTA;

-------------------------------------------------------------------------------------------
-- Kreiranje sekvenci
CREATE SEQUENCE SEQ_ISTRAZIVACKI_REZULTAT START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SEQ_ISTRAZIVAC          START WITH 1 INCREMENT BY 1 ;
CREATE SEQUENCE SEQ_ULOGA               START WITH 1 INCREMENT BY 1 ;
CREATE SEQUENCE SEQ_NI_INSTITUCIJA      START WITH 1 INCREMENT BY 1 ;
CREATE SEQUENCE SEQ_PUBLIKACIJA         START WITH 1 INCREMENT BY 1 ;
CREATE SEQUENCE SEQ_OCENA_RECENZENTA    START WITH 1 INCREMENT BY 1 ;

-------------------------------------------------------------------------------------------
-- Kreiranje baze podataka za upravljanje istraživačkim rezultatima
CREATE TABLE istrazivacki_rezultat(
    ID_IR NUMBER(10) PRIMARY KEY,
    NASLOV VARCHAR2(100) NOT NULL,
    APSTRAKT VARCHAR2(500) NOT NULL,
    DATUM_KREIRANJA DATE NOT NULL,
    DATUM_OBJAVLJIVANJA DATE NOT NULL,
    STATUS_IR VARCHAR2(20) DEFAULT 'U_PRIPREMI' NOT NULL,
    VIDLJIVOST NUMBER(1) DEFAULT 1 NOT NULL,

    CONSTRAINT CHK_STATUS CHECK (STATUS_IR IN ('U_PRIPREMI','POSLAT_NA_RECENZIJU','U_REVIZIJI','PRIHVACEN','ODBIJEN','OBJAVLJEN','ARHIVIRAN')),

    CONSTRAINT CHK_VIDLJIVOST CHECK (VIDLJIVOST IN (0,1))

);

    --Kjucne reci atributi
    CREATE TABLE kljucne_reci(
        ID_IR NUMBER(10) NOT NULL,
        KLJUCNA_REC VARCHAR2(50) NOT NULL,
        CONSTRAINT PK_KLJUCNE_RECI PRIMARY KEY (ID_IR, KLJUCNA_REC),
        CONSTRAINT FK_KLJUCNE_RECI_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
    );
    -- Vezrije rezultata
    CREATE TABLE verzija
    (
        ID_IR NUMBER(10) NOT NULL,
        BROJ_VERZIJE NUMBER(10) NOT NULL,
        DATUM_POSTAVLJANJA DATE NOT NULL,
        OPIS_IZMENA VARCHAR2(500) NOT NULL,
        ODGOVORNA_OSOBA VARCHAR2(100) NOT NULL,

        CONSTRAINT PK_VERZIJA PRIMARY KEY (ID_IR, BROJ_VERZIJE),
        --Ima--
        CONSTRAINT FK_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
    );

        --Pripadajuci fajlovi atributi
        CREATE TABLE pripadajuci_fajlovi(

            ID_IR NUMBER(10) NOT NULL,
            BROJ_VERZIJE NUMBER(10) NOT NULL,
            NAZIV_FAJLA VARCHAR2(100) NOT NULL,

            CONSTRAINT PK_PRIPADAJUCI_FAJLOVI PRIMARY KEY (ID_IR, BROJ_VERZIJE, NAZIV_FAJLA),
            CONSTRAINT FK_ID_R FOREIGN KEY (ID_IR, BROJ_VERZIJE) REFERENCES verzija(ID_IR, BROJ_VERZIJE) ON DELETE CASCADE
        );

--podklase istrazivackih rezultata
CREATE TABLE ostali_dokumenti(
    ID_IR NUMBER(10) PRIMARY KEY,
    OPCIJE VARCHAR2(100) NOT NULL,

    CONSTRAINT FK_OSTALI_DOKUMENTI_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
    CONSTRAINT CHK_OPCIJE CHECK (OPCIJE IN ('OBRAZOVNI_MATERIJAL','PREZENTACIJA','DOKTORSKA_DISERTACIJA'))
);

CREATE TABLE naucni_rad(
    ID_IR NUMBER(10) PRIMARY KEY,
    TIP_RADA VARCHAR2(100) DEFAULT 'CASOPIS' NOT NULL,
    NAZIV_CAS_KON VARCHAR2(100) NOT NULL,
    DOI VARCHAR2(100),
    ISSN_ILI_ISBN VARCHAR2(20),
    BROJ_SVESKE NUMBER(10) NOT NULL,
    BROJ_IZDANJA NUMBER(10) NOT NULL,
    BROJ_STRANICE NUMBER(10) NOT NULL,

    CONSTRAINT FK_NR_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
    CONSTRAINT CHK_TIP_RADA CHECK (TIP_RADA IN ('CASOPIS','KONFERENCIJA'))
);

CREATE TABLE knjiga_ili_poglavlja(
    ID_IR NUMBER(10) PRIMARY KEY,
    IZDAVAC VARCHAR2(100) NOT NULL,
    MESTO_IZDAVANJA VARCHAR2(100) NOT NULL,

    CONSTRAINT FK_KP_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
);

CREATE TABLE softverski_artifakt(
    ID_IR NUMBER(10) PRIMARY KEY,
    PROGRAMSKI_JEZIK VARCHAR2(50) NOT NULL,
    REPO_LINK VARCHAR2(200) NOT NULL,
    NACIN_LICENCIRANJA VARCHAR2(100) NOT NULL,
    DOKUMENTACIJA VARCHAR2(200) NOT NULL,

    CONSTRAINT FK_SA_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
);
    --podrzane platforme
    CREATE TABLE podrzane_platforme(
        ID_IR NUMBER(10) NOT NULL,
        PLATFORMA VARCHAR2(50) NOT NULL,

        CONSTRAINT CHK_PLATFORMA CHECK (PLATFORMA IN ('WINDOWS','LINUX','MACOS','WEB','ANDROID','IOS')),
        CONSTRAINT PK_PODRZANE_PLATFORME PRIMARY KEY (ID_IR, PLATFORMA),
        CONSTRAINT FK_PODRZANE_PLATFORME_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
    );

CREATE TABLE tehnicki_izvestaj(
    ID_IR NUMBER(10) PRIMARY KEY,

    CONSTRAINT FK_TI_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
);

CREATE TABLE dataset(
    ID_IR NUMBER(10) PRIMARY KEY,
    FORMAT VARCHAR2(50) NOT NULL,
    VELICINA NUMBER(10) NOT NULL,
    BROJ_ZAPISA NUMBER(10) NOT NULL,
    OPIS_STRUKTURE VARCHAR2(500) NOT NULL,
    PERIOD_OBUHVATA_PODATAKA VARCHAR2(100) NOT NULL,
    LICENCA_KORISCENJA VARCHAR2(100) NOT NULL,
    OGRANICENJA_PRISTUPA VARCHAR2(200) NOT NULL,

    CONSTRAINT FK_DS_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
);

 ------------------------------------------------------------------------------------------------------------
-- Kreiranje tabele za Istraživače

CREATE TABLE istrazivac(
    ID_I NUMBER(10) PRIMARY KEY,
    IME VARCHAR2(50) NOT NULL,
    DATUM_RODJENJA DATE NOT NULL,
    DRZAVA VARCHAR2(50) NOT NULL,
    PREZIME VARCHAR2(50) NOT NULL,
    NAUCNA_OBLAST VARCHAR2(100) NOT NULL,
    NAUCNO_ZVANJE VARCHAR2(100) NOT NULL,
    STATUS_NAUCNIKA VARCHAR2(20) DEFAULT 'AKTIVAN' NOT NULL,

    CONSTRAINT CHK_STATUS_NAUCNIKA CHECK (STATUS_NAUCNIKA IN ('AKTIVAN','NEAKTIVAN'))
);

    -- Mail I Telefoni atributi
    CREATE TABLE mail(
        ID_I NUMBER(10) NOT NULL,
        MAIL VARCHAR2(100) NOT NULL,

        CONSTRAINT CHK_MAIL CHECK (REGEXP_LIKE(MAIL, '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$')),
        CONSTRAINT PK_MAIL PRIMARY KEY (ID_I, MAIL),
        CONSTRAINT FK_MAIL_ID_I FOREIGN KEY (ID_I) REFERENCES istrazivac(ID_I) ON DELETE CASCADE
    );

    CREATE TABLE telefon(
        ID_I NUMBER(10) NOT NULL,
        TELEFON VARCHAR2(20) NOT NULL,

        CONSTRAINT CHK_TELEFON CHECK (REGEXP_LIKE(TELEFON, '^\+?[0-9]{9,15}$')),
        CONSTRAINT PK_TELEFON PRIMARY KEY (ID_I, TELEFON),
        CONSTRAINT FK_TELEFON_ID_I FOREIGN KEY (ID_I) REFERENCES istrazivac(ID_I) ON DELETE CASCADE
    );
-----------------------------------------------------------------------------------------------------------
-- Kreiranje tabele za Uloge

CREATE TABLE uloga(
    ID_U NUMBER(10) PRIMARY KEY,
    ID_I NUMBER(10),

    CONSTRAINT FK_ID_I FOREIGN KEY (ID_I) REFERENCES istrazivac(ID_I) ON DELETE CASCADE
);

CREATE TABLE rukovodilac_projekta(
    ID_U NUMBER(10) PRIMARY KEY,

    CONSTRAINT FK_RUKOVODILAC_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
);
--Administator repozitorijuma i njegova ovlašćenja
CREATE TABLE administrator_repozitorijuma(
    ID_U NUMBER(10) PRIMARY KEY,

    CONSTRAINT FK_ADMINISTRATOR_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
);
    --Administratorova ovlašćenja atributi
    CREATE TABLE Administrator_ovlascenja(
        ID_U NUMBER(10) NOT NULL,
        OVLASCENJE VARCHAR2(100) NOT NULL,
        CONSTRAINT FK_AO_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
    );

--Urednik
CREATE TABLE urednik(
    ID_U NUMBER(10) PRIMARY KEY,
    UREDJIVACKA_SEKCIJA VARCHAR2(100) NOT NULL,
    CONSTRAINT FK_UREDNIK_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
);

--Recenzent i oblasti recenziranja
CREATE TABLE recenzent(
    ID_U NUMBER(10) PRIMARY KEY,
    CONSTRAINT FK_RECENZENT_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
);
    --Oblasti ekspertize atributi
    CREATE TABLE oblasti_ekspertize(
        ID_U NUMBER(10) NOT NULL,
        OBLAST_EKSPERTIZE VARCHAR2(100) NOT NULL,

        CONSTRAINT FK_RECENZENT_OBLASTI_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
    );

--Autor
CREATE TABLE autor(
    ID_U NUMBER(10) PRIMARY KEY,
    ORCID VARCHAR2(30) NOT NULL,

    CONSTRAINT CHK_ORCID CHECK (REGEXP_LIKE(ORCID, '^\d{4}-\d{4}-\d{4}-\d{3}[X\d]$')), ---prihvata samo sa X na kraju sa cifrom zeza
    CONSTRAINT FK_AUTOR_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
);
--------------------------------------------------------------------------------------------------------------
-- Kreiranje tabele za Naucnoistraživačke Institucije

CREATE TABLE ni_institucija(
    ID_NII NUMBER(10) PRIMARY KEY,
    NAZIV VARCHAR2(100) UNIQUE NOT NULL,
    ADRESA VARCHAR2(200) NOT NULL
);

    --Naucne Oblasti I Kontakti atributi

    CREATE TABLE naucna_oblast(
        ID_NII NUMBER(10) NOT NULL,
        NAUCNA_OBLAST VARCHAR2(100) NOT NULL,

        CONSTRAINT PK_NAUCNA_OBLAST_INSTITUCIJA PRIMARY KEY (ID_NII, NAUCNA_OBLAST),
        CONSTRAINT FK_NAUCNA_OBLAST_ID_NII FOREIGN KEY (ID_NII) REFERENCES ni_institucija(ID_NII) ON DELETE CASCADE
    );

    CREATE TABLE mail_institucija(
        ID_NII NUMBER(10) NOT NULL,
        MAIL VARCHAR2(100) NOT NULL,

        CONSTRAINT CHK_MAIL_INSTITUCIJA CHECK (REGEXP_LIKE(MAIL, '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$')),
        CONSTRAINT PK_MAIL_INSTITUCIJA PRIMARY KEY (ID_NII, MAIL),
        CONSTRAINT FK_MAIL_ID_NII FOREIGN KEY (ID_NII) REFERENCES ni_institucija(ID_NII) ON DELETE CASCADE
    );

    CREATE TABLE telefon_institucija(
        ID_NII NUMBER(10) NOT NULL,
        TELEFON VARCHAR2(20) NOT NULL,

        CONSTRAINT CHK_TELEFON_INSTITUCIJA CHECK (REGEXP_LIKE(TELEFON, '^\+?[0-9]{9,15}$')),
        CONSTRAINT PK_TELEFON_INSTITUCIJA PRIMARY KEY (ID_NII, TELEFON),
        CONSTRAINT FK_TELEFON_ID_NII FOREIGN KEY (ID_NII) REFERENCES ni_institucija(ID_NII) ON DELETE CASCADE
    );

---------------------------------------------------------------------------------------------------------------
-- Kreiranje tabele za vezu Angazovanje Istraživača u Institucijama

CREATE TABLE angazovanje(
    ID_I NUMBER(10) NOT NULL,
    ID_NII NUMBER(10) NOT NULL,
    DATUM_ANGAZOVANJA DATE NOT NULL,
    DATUM_ZAVRSETKA DATE,
    ORGANIZACIONA_JEDINICA VARCHAR2(100) NOT NULL,
    NAZIV_POZICIJE VARCHAR2(100) NOT NULL,
    TIP_ANGAZOVANJA VARCHAR2(20) DEFAULT 'STALNI' NOT NULL,

    CONSTRAINT VREME_ANGAZOVANJA CHECK (DATUM_ZAVRSETKA IS NULL OR DATUM_ZAVRSETKA >= DATUM_ANGAZOVANJA),
    CONSTRAINT PK_ANGAZOVANJE PRIMARY KEY (ID_I, ID_NII),
    CONSTRAINT FK_ANGAZOVANJE_ID_I FOREIGN KEY (ID_I) REFERENCES istrazivac(ID_I) ON DELETE CASCADE,
    CONSTRAINT FK_ANGAZOVANJE_ID_NII FOREIGN KEY (ID_NII) REFERENCES ni_institucija(ID_NII) ON DELETE CASCADE,
    CONSTRAINT CHK_TIP_ANGAZOVANJA CHECK (TIP_ANGAZOVANJA IN ('STALNI','PRIVREMEN'))
);

-----------------------------------------------------------------------------------------------------------------
-- Publikacija

CREATE TABLE publikacija(
    ID_P NUMBER(10) PRIMARY KEY,
    ID_D NUMBER(10) UNIQUE,
    ID_TI NUMBER(10) UNIQUE,
    ID_SA NUMBER(10) UNIQUE,

    CONSTRAINT FK_PUBLIKACIJA_ID_D FOREIGN KEY (ID_D) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
    CONSTRAINT FK_PUBLIKACIJA_ID_TI FOREIGN KEY (ID_TI) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
    CONSTRAINT FK_PUBLIKACIJA_ID_SA FOREIGN KEY (ID_SA) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
);

    -- Citat atributi
    CREATE TABLE citat(
        ID_P1 NUMBER(10) NOT NULL,
        ID_P2 NUMBER(10) NOT NULL,
        CITIRAJUCA_PUBLIKACIJA VARCHAR2(100) NOT NULL,
        CITIRANA_PUBLIKACIJA VARCHAR2(100) NOT NULL,
        TIP_CITATA VARCHAR2(20) DEFAULT 'INDIREKTAN' NOT NULL,
        MESTO_CITIRANJA VARCHAR2(100) NOT NULL,
        KONTEKST_CITIRANJA VARCHAR2(500) NOT NULL,

        CONSTRAINT PK_CITAT PRIMARY KEY (ID_P1, ID_P2),
        CONSTRAINT FK_CITAT_ID_P1 FOREIGN KEY (ID_P1) REFERENCES publikacija(ID_P) ON DELETE CASCADE,
        CONSTRAINT FK_CITAT_ID_P2 FOREIGN KEY (ID_P2) REFERENCES publikacija(ID_P) ON DELETE CASCADE,
        CONSTRAINT CHK_TIP_CITATA CHECK (TIP_CITATA IN ('INDIREKTAN','DIREKTAN'))
    );

-------------------------------------------------------------------------------------------------------------------
--Autorstvo

CREATE TABLE autorstvo(
    ID_U NUMBER(10) NOT NULL,
    ID_P NUMBER(10) NOT NULL,
    REDNI_BROJ_AUTORA NUMBER(10) NOT NULL,
    TIP_DOPRINOSA VARCHAR2(100) NOT NULL,
    ULOGA_U_PUBLIKACIJI VARCHAR2(100) NOT NULL,

    CONSTRAINT PK_AUTORSTVO PRIMARY KEY (ID_U, ID_P),
    CONSTRAINT FK_AUTORSTVO_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE,
    CONSTRAINT FK_AUTORSTVO_ID_P FOREIGN KEY (ID_P) REFERENCES publikacija(ID_P) ON DELETE CASCADE
);
------------------------------------------------------------------------------------------------------------------
--Runda recenzije

CREATE TABLE runda_recenzije(
    ID_P NUMBER(10) NOT NULL,
    ID_UREDNIKA NUMBER(10)  NOT NULL,--UNIQUE obisan
    BROJ_RUNDE NUMBER(10) NOT NULL,
    DATUM_ODLUKE DATE NOT NULL,
    KONACNA_ODLUKA VARCHAR2(20) DEFAULT 'POTREBNA_REVIZIJA' NOT NULL,

    CONSTRAINT PK_RR PRIMARY KEY (ID_P,BROJ_RUNDE),
    CONSTRAINT FK_RR_ID_UREDNIKA FOREIGN KEY (ID_UREDNIKA) REFERENCES urednik(ID_U) ON DELETE CASCADE,
    CONSTRAINT FK_RR_ID_P FOREIGN KEY (ID_P) REFERENCES publikacija(ID_P) ON DELETE CASCADE,
    CONSTRAINT CHK_KONACNA_ODLUKA CHECK (KONACNA_ODLUKA IN ('POTREBNA_REVIZIJA','PRIHVACENA','ODBIJENA'))
);

    --Angazovanje recenzenti
    CREATE TABLE angazovanje_recenzent(
        ID_P NUMBER(10) NOT NULL,
        ID_RECENZENTA NUMBER(10) NOT NULL,
        BROJ_RUNDE NUMBER(10) NOT NULL,
        PREPORUKA VARCHAR2(10) DEFAULT 'NE' NOT NULL,

        CONSTRAINT CHK_PREPORUKA CHECK (PREPORUKA IN ('DA','NE')),
        CONSTRAINT PK_ANG_REC PRIMARY KEY (ID_P, ID_RECENZENTA, BROJ_RUNDE),
        CONSTRAINT FK_ANG_REC_ID_RUN_REC FOREIGN KEY (ID_P,BROJ_RUNDE) REFERENCES runda_recenzije(ID_P,BROJ_RUNDE) ON DELETE CASCADE,
        CONSTRAINT FK_ANG_REC_ID_REC FOREIGN KEY (ID_RECENZENTA) REFERENCES recenzent(ID_U) ON DELETE CASCADE
    );

        --Ocena recenzenta atribut
        CREATE TABLE ocena_recenzenta(
            ID_O NUMBER(10) PRIMARY KEY,
            ID_P NUMBER(10) NOT NULL,
            ID_RECENZENTA NUMBER(10) NOT NULL,
            BROJ_RUNDE NUMBER(10) NOT NULL,
            OCENA NUMBER(1) NOT NULL,

            CONSTRAINT CHK_OCENA CHECK (OCENA BETWEEN 1 AND 5),
            --CONSTRAINT PK_OCENA PRIMARY KEY (ID_P, ID_RECENZENTA,BROJ_RUNDE,OCENA),
            CONSTRAINT FK_OCENA_ID_ANG_REC FOREIGN KEY (ID_P, ID_RECENZENTA, BROJ_RUNDE) REFERENCES angazovanje_recenzent(ID_P, ID_RECENZENTA, BROJ_RUNDE) ON DELETE CASCADE
            --CONSTRAINT FK_OCENA_ID_REC FOREIGN KEY (ID_RECENZENTA) REFERENCES recenzent(ID_U) ON DELETE CASCADE
        );
-------------------------------------------------------------------------------------------------------------------
-- Ureduje
CREATE TABLE uredjuje(
    ID_IR NUMBER(10) NOT NULL,
    ID_UREDNIKA NUMBER(10) NOT NULL,

    CONSTRAINT PK_UREDI PRIMARY KEY (ID_IR, ID_UREDNIKA),
    CONSTRAINT FK_UREDI_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
    CONSTRAINT FK_UREDI_ID_UREDNIKA FOREIGN KEY (ID_UREDNIKA) REFERENCES urednik(ID_U) ON DELETE CASCADE
);
-------------------------------------------------------------------------------------------------------------------
--Unos test podataka
DECLARE
    new_ID_IR istrazivacki_rezultat.ID_IR%TYPE;
    new_ID_P publikacija.ID_P%TYPE;
    new_ID_U uloga.ID_U%TYPE;
    new_ID_I istrazivac.ID_I%TYPE;
    new_ID_NII ni_institucija.ID_NII%TYPE;

BEGIN
    -- Kreiranje entiteta roditelja; ID se sada eksplicitno uzima iz sekvence
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV,APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Uticaj udica na ajkule','Prvi istrazivacki rezultat u bazi',TO_DATE('2023-01-01', 'YYYY-MM-DD'),TO_DATE('2026-02-14', 'YYYY-MM-DD'),'POSLAT_NA_RECENZIJU','1')
    RETURNING ID_IR INTO new_ID_IR;

    -- Kreiranje entiteta koji koristi sacuvani ID kao FK
    INSERT INTO ostali_dokumenti(ID_IR, OPCIJE)
    VALUES (new_ID_IR, 'OBRAZOVNI_MATERIJAL');

    INSERT INTO kljucne_reci (ID_IR,KLJUCNA_REC)
    VALUES (new_ID_IR, 'Ajkula');
    INSERT INTO kljucne_reci (ID_IR,KLJUCNA_REC)
    VALUES (new_ID_IR, 'Udica');
    INSERT INTO kljucne_reci (ID_IR,KLJUCNA_REC)
    VALUES (new_ID_IR, 'Ekologija');

    INSERT INTO  verzija(ID_IR,BROJ_VERZIJE,DATUM_POSTAVLJANJA,OPIS_IZMENA,ODGOVORNA_OSOBA)
    VALUES (new_ID_IR, 1, TO_DATE('2024-02-14', 'YYYY-MM-DD'), 'Dodatna pojasnjenja neprecizno definisanih pojmova', 'Marko Nikolic');
    INSERT INTO  pripadajuci_fajlovi(ID_IR,BROJ_VERZIJE, NAZIV_FAJLA)
    VALUES (new_ID_IR, 1, 'Fajl br. 1');
    INSERT INTO  pripadajuci_fajlovi(ID_IR,BROJ_VERZIJE, NAZIV_FAJLA)
    VALUES (new_ID_IR, 1, 'Fajl br. 2');

    INSERT INTO  verzija(ID_IR,BROJ_VERZIJE,DATUM_POSTAVLJANJA,OPIS_IZMENA,ODGOVORNA_OSOBA)
    VALUES (new_ID_IR, 2, TO_DATE('2025-02-11', 'YYYY-MM-DD'), 'Ispravke gresaka u kucanju', 'Pera Peric');
    INSERT INTO  pripadajuci_fajlovi(ID_IR,BROJ_VERZIJE, NAZIV_FAJLA)
    VALUES (new_ID_IR, 2, 'Fajl br. 1');
    INSERT INTO  pripadajuci_fajlovi(ID_IR,BROJ_VERZIJE, NAZIV_FAJLA)
    VALUES (new_ID_IR, 2, 'Fajl br. 2');
    --------------------------------------------------------------------------------------------------------------------------------------------------
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV,APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Efekat staklene baste','Drugi istrazivacki rezultat u bazi',TO_DATE('2026-01-01', 'YYYY-MM-DD'),TO_DATE('2026-08-14', 'YYYY-MM-DD'),'OBJAVLJEN','1')
    RETURNING ID_IR INTO new_ID_IR;

    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA,DRZAVA,PREZIME, NAUCNA_OBLAST,NAUCNO_ZVANJE,STATUS_NAUCNIKA)
    VALUES(SEQ_ISTRAZIVAC.NEXTVAL, 'Andrej', TO_DATE('1989-12-23', 'YYYY-MM-DD'), 'Bugarska', 'Bugalkov', 'Ekologija','Magistar biologije', 'AKTIVAN')
    RETURNING ID_I into new_ID_I;

    INSERT INTO mail(ID_I, MAIL)
    VALUES(new_ID_I, 'AndrejBugalkov@gmail.com');
    INSERT INTO mail(ID_I, MAIL)
    VALUES(new_ID_I, 'AB89@gmail.com');

    INSERT INTO telefon(ID_I, TELEFON)
    VALUES(new_ID_I, '+381632327744');
    INSERT INTO telefon(ID_I, TELEFON)
    VALUES(new_ID_I, '+38160552424');

    INSERT INTO dataset(ID_IR, FORMAT,VELICINA, BROJ_ZAPISA, OPIS_STRUKTURE, PERIOD_OBUHVATA_PODATAKA, LICENCA_KORISCENJA, OGRANICENJA_PRISTUPA)
    VALUES (new_ID_IR, 'JSON', '1024', 20, 'standardna struktura', ' od 10-10-2010 do 11-11-2010', 'Markova licenca', 'read-only');

    INSERT INTO kljucne_reci (ID_IR,KLJUCNA_REC)
    VALUES (new_ID_IR, 'Staklena basta');
    INSERT INTO kljucne_reci (ID_IR,KLJUCNA_REC)
    VALUES (new_ID_IR, 'Globalno zagrevanje');
    INSERT INTO kljucne_reci (ID_IR,KLJUCNA_REC)
    VALUES (new_ID_IR, 'Ekologija');

    INSERT INTO uloga(ID_U, ID_I)
    VALUES(SEQ_ULOGA.NEXTVAL, new_ID_I) 
    RETURNING ID_U INTO new_ID_U;

    INSERT INTO autor(ID_U, ORCID)
    VALUES(new_ID_U, '1234-0002-1825-009X');

    -----------------------------------------------------------------------------------------------------------------------------------------------------
    Insert into istrazivacki_rezultat(ID_IR, NASLOV,APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    values (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Negativni efekti duvanskig dima','Treci istrazivacki rezultat u bazi',TO_DATE('2016-02-01', 'YYYY-MM-DD'),TO_DATE('2021-07-14', 'YYYY-MM-DD'),'ARHIVIRAN','0')
    RETURNING ID_IR INTO new_ID_IR;

    INSERT INTO softverski_artifakt(ID_IR, PROGRAMSKI_JEZIK,REPO_LINK, NACIN_LICENCIRANJA, DOKUMENTACIJA)
    VALUES (new_ID_IR, 'c++', 'www.github.com', 'SaaS', 'dokument.txt');

    INSERT INTO podrzane_platforme(ID_IR, PLATFORMA)
    VALUES(new_ID_IR, 'WINDOWS');
    INSERT INTO podrzane_platforme(ID_IR, PLATFORMA)
    VALUES (new_ID_IR, 'MACOS');
    INSERT INTO podrzane_platforme(ID_IR, PLATFORMA)
    VALUES(new_ID_IR, 'LINUX');
    -----------------------------------------------------------------------------------------------------------------------------------------------------
    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA,DRZAVA,PREZIME, NAUCNA_OBLAST,NAUCNO_ZVANJE,STATUS_NAUCNIKA)
    VALUES(SEQ_ISTRAZIVAC.NEXTVAL, 'Petar', TO_DATE('1967-02-23', 'YYYY-MM-DD'), 'Srbija', 'Petrovic', 'Matematika','Doktor matematickih nauka', 'AKTIVAN')
    RETURNING ID_I into new_ID_I;

    INSERT INTO mail(ID_I, MAIL)
    VALUES(new_ID_I, 'PetarPetrovic@gmail.com');
    INSERT INTO mail(ID_I, MAIL)
    VALUES(new_ID_I, 'PeraZdera67@gmail.com');

    INSERT INTO telefon(ID_I, TELEFON)
    VALUES(new_ID_I, '+381632224444');
    INSERT INTO telefon(ID_I, TELEFON)
    VALUES(new_ID_I, '+38163555444');


    INSERT INTO uloga(ID_U, ID_I)
    VALUES(SEQ_ULOGA.NEXTVAL, new_ID_I)
    RETURNING ID_U INTO new_ID_U;

    INSERT INTO recenzent(ID_U)
    VALUES(new_ID_U);

    INSERT INTO oblasti_ekspertize(ID_U,OBLAST_EKSPERTIZE)
    VALUES(new_ID_U, 'Matematika');
    INSERT INTO oblasti_ekspertize(ID_U,OBLAST_EKSPERTIZE)
    VALUES(new_ID_U, 'Racunarske nauke');
    INSERT INTO oblasti_ekspertize(ID_U,OBLAST_EKSPERTIZE)
    VALUES(new_ID_U, 'Fizika');



    INSERT INTO ni_institucija(ID_NII, NAZIV, ADRESA)
    VALUES(SEQ_NI_INSTITUCIJA.NEXTVAL, 'Matematicki institut', 'Narodnih heroja BB')
    RETURNING ID_NII INTO new_ID_NII;

    INSERT INTO naucna_oblast(ID_NII, NAUCNA_OBLAST)
    VALUES(new_ID_NII, 'Matematika');

    INSERT INTO naucna_oblast(ID_NII, NAUCNA_OBLAST)
    VALUES(new_ID_NII, 'Fizika');

    INSERT INTO mail_institucija(ID_NII, MAIL)
    VALUES(new_ID_NII, 'MatematickiInstitut@gmail.com');
    INSERT INTO mail_institucija(ID_NII, MAIL)
    VALUES(new_ID_NII, 'DepartmanZaMatematiku@gmail.com');

    INSERT INTO telefon_institucija(ID_NII, TELEFON)
    VALUES(new_ID_NII, '+38161234678');
    INSERT INTO telefon_institucija(ID_NII, TELEFON)
    VALUES(new_ID_NII, '+38160555432');

    INSERT INTO angazovanje(ID_I, ID_NII, DATUM_ANGAZOVANJA, DATUM_ZAVRSETKA, ORGANIZACIONA_JEDINICA, NAZIV_POZICIJE, TIP_ANGAZOVANJA)
    VALUES(new_ID_I,new_ID_NII, TO_DATE('2014-02-23', 'YYYY-MM-DD'),TO_DATE('2028-02-23', 'YYYY-MM-DD'), 'Matematicki fakultet', 'Profesor', 'PRIVREMEN');



    COMMIT;
END;

-------------------------------------------------------------------------------------------
-- Jos test podataka
-------------------------------------------------------------------------------------------

DECLARE
    new_ID_IR   istrazivacki_rezultat.ID_IR%TYPE;
    new_ID_P    publikacija.ID_P%TYPE;
    new_ID_U    uloga.ID_U%TYPE;
    new_ID_I    istrazivac.ID_I%TYPE;
    new_ID_NII  ni_institucija.ID_NII%TYPE;
    new_ID_O    ocena_recenzenta.ID_O%TYPE;

    -- istrazivaci
    id_i_marija   istrazivac.ID_I%TYPE;
    id_i_nikola   istrazivac.ID_I%TYPE;
    id_i_ana      istrazivac.ID_I%TYPE;
    id_i_stefan   istrazivac.ID_I%TYPE;
    id_i_jovan    istrazivac.ID_I%TYPE;
    id_i_milica   istrazivac.ID_I%TYPE;

    -- uloge
    id_u_autor_marija   uloga.ID_U%TYPE;
    id_u_autor_nikola   uloga.ID_U%TYPE;
    id_u_urednik_nikola uloga.ID_U%TYPE;
    id_u_recenzent_ana  uloga.ID_U%TYPE;
    id_u_recenzent_stefan uloga.ID_U%TYPE;
    id_u_rukovodilac_jovan uloga.ID_U%TYPE;
    id_u_admin_milica   uloga.ID_U%TYPE;

    -- istrazivacki rezultati (podklase)
    ir_dataset   istrazivacki_rezultat.ID_IR%TYPE;
    ir_softver   istrazivacki_rezultat.ID_IR%TYPE;
    ir_tehizv    istrazivacki_rezultat.ID_IR%TYPE;
    ir_naucnirad istrazivacki_rezultat.ID_IR%TYPE;
    ir_knjiga    istrazivacki_rezultat.ID_IR%TYPE;
    ir_ostalo    istrazivacki_rezultat.ID_IR%TYPE;

    -- publikacije
    p_dataset  publikacija.ID_P%TYPE;
    p_softver  publikacija.ID_P%TYPE;
    p_tehizv   publikacija.ID_P%TYPE;

    -- institucije
    nii_pmf    ni_institucija.ID_NII%TYPE;
    nii_irn    ni_institucija.ID_NII%TYPE;

BEGIN
    -----------------------------------------------------------------------------------
    -- 1) ISTRAZIVACI 
    -----------------------------------------------------------------------------------
    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA, DRZAVA, PREZIME, NAUCNA_OBLAST, NAUCNO_ZVANJE, STATUS_NAUCNIKA)
    VALUES (SEQ_ISTRAZIVAC.NEXTVAL, 'Marija', TO_DATE('1990-05-14','YYYY-MM-DD'), 'Srbija', 'Jovanovic', 'Ekologija', 'Doktor bioloskih nauka', 'AKTIVAN')
    RETURNING ID_I INTO id_i_marija;
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_marija, 'marija.jovanovic@pmf.rs');
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_marija, 'mjovanovic@gmail.com');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_marija, '+381641112233');

    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA, DRZAVA, PREZIME, NAUCNA_OBLAST, NAUCNO_ZVANJE, STATUS_NAUCNIKA)
    VALUES (SEQ_ISTRAZIVAC.NEXTVAL, 'Nikola', TO_DATE('1985-11-02','YYYY-MM-DD'), 'Srbija', 'Simic', 'Racunarske nauke', 'Docent', 'AKTIVAN')
    RETURNING ID_I INTO id_i_nikola;
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_nikola, 'nikola.simic@irn.rs');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_nikola, '+381621234567');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_nikola, '+38162555111');

    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA, DRZAVA, PREZIME, NAUCNA_OBLAST, NAUCNO_ZVANJE, STATUS_NAUCNIKA)
    VALUES (SEQ_ISTRAZIVAC.NEXTVAL, 'Ana', TO_DATE('1978-03-21','YYYY-MM-DD'), 'Srbija', 'Petrovic', 'Klimatologija', 'Redovni profesor', 'AKTIVAN')
    RETURNING ID_I INTO id_i_ana;
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_ana, 'ana.petrovic@pmf.rs');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_ana, '+381601112233');

    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA, DRZAVA, PREZIME, NAUCNA_OBLAST, NAUCNO_ZVANJE, STATUS_NAUCNIKA)
    VALUES (SEQ_ISTRAZIVAC.NEXTVAL, 'Stefan', TO_DATE('1982-07-09','YYYY-MM-DD'), 'Srbija', 'Ilic', 'Racunarske nauke', 'Vanredni profesor', 'AKTIVAN')
    RETURNING ID_I INTO id_i_stefan;
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_stefan, 'stefan.ilic@irn.rs');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_stefan, '+381691112233');

    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA, DRZAVA, PREZIME, NAUCNA_OBLAST, NAUCNO_ZVANJE, STATUS_NAUCNIKA)
    VALUES (SEQ_ISTRAZIVAC.NEXTVAL, 'Jovan', TO_DATE('1975-01-30','YYYY-MM-DD'), 'Srbija', 'Kovac', 'Biologija', 'Redovni profesor', 'AKTIVAN')
    RETURNING ID_I INTO id_i_jovan;
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_jovan, 'jovan.kovac@pmf.rs');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_jovan, '+381631112233');

    INSERT INTO istrazivac(ID_I, IME, DATUM_RODJENJA, DRZAVA, PREZIME, NAUCNA_OBLAST, NAUCNO_ZVANJE, STATUS_NAUCNIKA)
    VALUES (SEQ_ISTRAZIVAC.NEXTVAL, 'Milica', TO_DATE('1993-09-18','YYYY-MM-DD'), 'Srbija', 'Stanic', 'Informacione tehnologije', 'Master informatike', 'AKTIVAN')
    RETURNING ID_I INTO id_i_milica;
    INSERT INTO mail(ID_I, MAIL) VALUES (id_i_milica, 'milica.stanic@irn.rs');
    INSERT INTO telefon(ID_I, TELEFON) VALUES (id_i_milica, '+381651112233');

    -----------------------------------------------------------------------------------
    -- 2) ULOGE 
    -----------------------------------------------------------------------------------
    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_marija) RETURNING ID_U INTO id_u_autor_marija;
    INSERT INTO autor(ID_U, ORCID) VALUES (id_u_autor_marija, '0000-0001-2345-678X');

    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_nikola) RETURNING ID_U INTO id_u_autor_nikola;
    INSERT INTO autor(ID_U, ORCID) VALUES (id_u_autor_nikola, '0000-0002-3456-789X');

    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_nikola) RETURNING ID_U INTO id_u_urednik_nikola;
    INSERT INTO urednik(ID_U, UREDJIVACKA_SEKCIJA) VALUES (id_u_urednik_nikola, 'Racunarske nauke');

    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_ana) RETURNING ID_U INTO id_u_recenzent_ana;
    INSERT INTO recenzent(ID_U) VALUES (id_u_recenzent_ana);
    INSERT INTO oblasti_ekspertize(ID_U, OBLAST_EKSPERTIZE) VALUES (id_u_recenzent_ana, 'Klimatologija');
    INSERT INTO oblasti_ekspertize(ID_U, OBLAST_EKSPERTIZE) VALUES (id_u_recenzent_ana, 'Ekologija');

    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_stefan) RETURNING ID_U INTO id_u_recenzent_stefan;
    INSERT INTO recenzent(ID_U) VALUES (id_u_recenzent_stefan);
    INSERT INTO oblasti_ekspertize(ID_U, OBLAST_EKSPERTIZE) VALUES (id_u_recenzent_stefan, 'Softversko inzenjerstvo');

    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_jovan) RETURNING ID_U INTO id_u_rukovodilac_jovan;
    INSERT INTO rukovodilac_projekta(ID_U) VALUES (id_u_rukovodilac_jovan);

    INSERT INTO uloga(ID_U, ID_I) VALUES (SEQ_ULOGA.NEXTVAL, id_i_milica) RETURNING ID_U INTO id_u_admin_milica;
    INSERT INTO administrator_repozitorijuma(ID_U) VALUES (id_u_admin_milica);
    INSERT INTO administrator_ovlascenja(ID_U, OVLASCENJE) VALUES (id_u_admin_milica, 'UPRAVLJANJE_KORISNICIMA');
    INSERT INTO administrator_ovlascenja(ID_U, OVLASCENJE) VALUES (id_u_admin_milica, 'BRISANJE_SADRZAJA');

    -----------------------------------------------------------------------------------
    -- 3) NAUCNOISTRAZIVACKE INSTITUCIJE 
    -----------------------------------------------------------------------------------
    INSERT INTO ni_institucija(ID_NII, NAZIV, ADRESA)
    VALUES (SEQ_NI_INSTITUCIJA.NEXTVAL, 'Prirodno-matematicki fakultet Nis', 'Visegradska 33, Nis')
    RETURNING ID_NII INTO nii_pmf;
    INSERT INTO naucna_oblast(ID_NII, NAUCNA_OBLAST) VALUES (nii_pmf, 'Ekologija');
    INSERT INTO naucna_oblast(ID_NII, NAUCNA_OBLAST) VALUES (nii_pmf, 'Klimatologija');
    INSERT INTO mail_institucija(ID_NII, MAIL) VALUES (nii_pmf, 'kontakt@pmf.rs');
    INSERT INTO mail_institucija(ID_NII, MAIL) VALUES (nii_pmf, 'dekanat@pmf.rs');
    INSERT INTO telefon_institucija(ID_NII, TELEFON) VALUES (nii_pmf, '+381181234567');

    INSERT INTO ni_institucija(ID_NII, NAZIV, ADRESA)
    VALUES (SEQ_NI_INSTITUCIJA.NEXTVAL, 'Institut za racunarske nauke', 'Bulevar oslobodjenja 12, Beograd')
    RETURNING ID_NII INTO nii_irn;
    INSERT INTO naucna_oblast(ID_NII, NAUCNA_OBLAST) VALUES (nii_irn, 'Racunarske nauke');
    INSERT INTO mail_institucija(ID_NII, MAIL) VALUES (nii_irn, 'info@irn.rs');
    INSERT INTO telefon_institucija(ID_NII, TELEFON) VALUES (nii_irn, '+381112223344');
    INSERT INTO telefon_institucija(ID_NII, TELEFON) VALUES (nii_irn, '+381113334455');

    INSERT INTO angazovanje(ID_I, ID_NII, DATUM_ANGAZOVANJA, DATUM_ZAVRSETKA, ORGANIZACIONA_JEDINICA, NAZIV_POZICIJE, TIP_ANGAZOVANJA)
    VALUES (id_i_marija, nii_pmf, TO_DATE('2018-09-01','YYYY-MM-DD'), NULL, 'Departman za biologiju', 'Docent', 'STALNI');
    INSERT INTO angazovanje(ID_I, ID_NII, DATUM_ANGAZOVANJA, DATUM_ZAVRSETKA, ORGANIZACIONA_JEDINICA, NAZIV_POZICIJE, TIP_ANGAZOVANJA)
    VALUES (id_i_ana, nii_pmf, TO_DATE('2005-10-01','YYYY-MM-DD'), NULL, 'Departman za geografiju', 'Redovni profesor', 'STALNI');
    INSERT INTO angazovanje(ID_I, ID_NII, DATUM_ANGAZOVANJA, DATUM_ZAVRSETKA, ORGANIZACIONA_JEDINICA, NAZIV_POZICIJE, TIP_ANGAZOVANJA)
    VALUES (id_i_nikola, nii_irn, TO_DATE('2015-03-15','YYYY-MM-DD'), NULL, 'Katedra za softversko inzenjerstvo', 'Docent', 'STALNI');
    INSERT INTO angazovanje(ID_I, ID_NII, DATUM_ANGAZOVANJA, DATUM_ZAVRSETKA, ORGANIZACIONA_JEDINICA, NAZIV_POZICIJE, TIP_ANGAZOVANJA)
    VALUES (id_i_stefan, nii_irn, TO_DATE('2012-01-10','YYYY-MM-DD'), NULL, 'Katedra za softversko inzenjerstvo', 'Vanredni profesor', 'STALNI');

    -----------------------------------------------------------------------------------
    -- 4) ISTRAZIVACKI REZULTATI
    -----------------------------------------------------------------------------------

    -- 4.1 DATASET
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV, APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Klimatski podaci Balkana 2000-2024', 'Skup meteoroloskih merenja za region Balkana', TO_DATE('2024-03-01','YYYY-MM-DD'), TO_DATE('2024-06-15','YYYY-MM-DD'), 'OBJAVLJEN', 1)
    RETURNING ID_IR INTO ir_dataset;
    INSERT INTO dataset(ID_IR, FORMAT, VELICINA, BROJ_ZAPISA, OPIS_STRUKTURE, PERIOD_OBUHVATA_PODATAKA, LICENCA_KORISCENJA, OGRANICENJA_PRISTUPA)
    VALUES (ir_dataset, 'CSV', 512, 150000, 'Kolone: datum, lokacija, temperatura, padavine', '2000-01-01 do 2024-12-31', 'CC BY 4.0', 'Slobodan pristup');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_dataset, 'Klima');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_dataset, 'Balkan');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_dataset, 'Meteorologija');
    INSERT INTO verzija(ID_IR, BROJ_VERZIJE, DATUM_POSTAVLJANJA, OPIS_IZMENA, ODGOVORNA_OSOBA)
    VALUES (ir_dataset, 1, TO_DATE('2024-03-01','YYYY-MM-DD'), 'Inicijalna verzija', 'Marija Jovanovic');
    INSERT INTO pripadajuci_fajlovi(ID_IR, BROJ_VERZIJE, NAZIV_FAJLA) VALUES (ir_dataset, 1, 'klima_2000_2024.csv');
    INSERT INTO pripadajuci_fajlovi(ID_IR, BROJ_VERZIJE, NAZIV_FAJLA) VALUES (ir_dataset, 1, 'metapodaci.pdf');

    -- 4.2 SOFTVERSKI ARTIFAKT
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV, APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'AnalizaPodatakaLib', 'Biblioteka za statisticku analizu klimatskih podataka', TO_DATE('2023-11-01','YYYY-MM-DD'), TO_DATE('2024-01-20','YYYY-MM-DD'), 'OBJAVLJEN', 1)
    RETURNING ID_IR INTO ir_softver;
    INSERT INTO softverski_artifakt(ID_IR, PROGRAMSKI_JEZIK, REPO_LINK, NACIN_LICENCIRANJA, DOKUMENTACIJA)
    VALUES (ir_softver, 'Python', 'https://github.com/irn/analiza-podataka-lib', 'MIT', 'https://irn.rs/docs/analiza-podataka-lib');
    INSERT INTO podrzane_platforme(ID_IR, PLATFORMA) VALUES (ir_softver, 'WINDOWS');
    INSERT INTO podrzane_platforme(ID_IR, PLATFORMA) VALUES (ir_softver, 'LINUX');
    INSERT INTO podrzane_platforme(ID_IR, PLATFORMA) VALUES (ir_softver, 'MACOS');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_softver, 'Python');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_softver, 'Statistika');
    INSERT INTO verzija(ID_IR, BROJ_VERZIJE, DATUM_POSTAVLJANJA, OPIS_IZMENA, ODGOVORNA_OSOBA)
    VALUES (ir_softver, 1, TO_DATE('2023-11-01','YYYY-MM-DD'), 'Prva javna verzija', 'Nikola Simic');
    INSERT INTO verzija(ID_IR, BROJ_VERZIJE, DATUM_POSTAVLJANJA, OPIS_IZMENA, ODGOVORNA_OSOBA)
    VALUES (ir_softver, 2, TO_DATE('2024-01-20','YYYY-MM-DD'), 'Ispravke gresaka, dodata podrska za MacOS', 'Nikola Simic');
    INSERT INTO pripadajuci_fajlovi(ID_IR, BROJ_VERZIJE, NAZIV_FAJLA) VALUES (ir_softver, 2, 'analiza_podataka_lib-1.1.0.whl');

    -- 4.3 TEHNICKI IZVESTAJ
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV, APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Izvestaj o kvalitetu vazduha u Nisu 2024', 'Godisnji tehnicki izvestaj o merenjima kvaliteta vazduha', TO_DATE('2024-12-01','YYYY-MM-DD'), TO_DATE('2025-01-15','YYYY-MM-DD'), 'POSLAT_NA_RECENZIJU', 1)
    RETURNING ID_IR INTO ir_tehizv;
    INSERT INTO tehnicki_izvestaj(ID_IR) VALUES (ir_tehizv);
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_tehizv, 'Kvalitet vazduha');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_tehizv, 'Nis');
    INSERT INTO verzija(ID_IR, BROJ_VERZIJE, DATUM_POSTAVLJANJA, OPIS_IZMENA, ODGOVORNA_OSOBA)
    VALUES (ir_tehizv, 1, TO_DATE('2024-12-01','YYYY-MM-DD'), 'Inicijalna verzija', 'Ana Petrovic');
    INSERT INTO pripadajuci_fajlovi(ID_IR, BROJ_VERZIJE, NAZIV_FAJLA) VALUES (ir_tehizv, 1, 'izvestaj_kvalitet_vazduha_2024.pdf');

    -- 4.4 NAUCNI RAD 
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV, APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Uticaj klimatskih promena na bioraznolikost', 'Pregledni rad o efektima klimatskih promena na ekosisteme', TO_DATE('2022-04-10','YYYY-MM-DD'), TO_DATE('2022-09-05','YYYY-MM-DD'), 'OBJAVLJEN', 1)
    RETURNING ID_IR INTO ir_naucnirad;
    INSERT INTO naucni_rad(ID_IR, TIP_RADA, NAZIV_CAS_KON, DOI, ISSN_ILI_ISBN, BROJ_SVESKE, BROJ_IZDANJA, BROJ_STRANICE)
    VALUES (ir_naucnirad, 'CASOPIS', 'Ekoloski glasnik', '10.1234/eko.2022.09', '1234-5678', 14, 3, 25);
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_naucnirad, 'Bioraznolikost');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_naucnirad, 'Klimatske promene');

    -- 4.5 KNJIGA ILI POGLAVLJE 
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV, APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Osnove ekologije', 'Udzbenik iz osnova ekologije za studente osnovnih studija', TO_DATE('2019-08-01','YYYY-MM-DD'), TO_DATE('2020-01-15','YYYY-MM-DD'), 'ARHIVIRAN', 1)
    RETURNING ID_IR INTO ir_knjiga;
    INSERT INTO knjiga_ili_poglavlja(ID_IR, IZDAVAC, MESTO_IZDAVANJA)
    VALUES (ir_knjiga, 'Prirodno-matematicki fakultet', 'Nis');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_knjiga, 'Ekologija');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_knjiga, 'Udzbenik');

    -- 4.6 OSTALI DOKUMENTI
    INSERT INTO istrazivacki_rezultat(ID_IR, NASLOV, APSTRAKT, DATUM_KREIRANJA, DATUM_OBJAVLJIVANJA, STATUS_IR, VIDLJIVOST)
    VALUES (SEQ_ISTRAZIVACKI_REZULTAT.NEXTVAL, 'Prezentacija projektnih rezultata', 'Prezentacija sa zavrsne konferencije projekta', TO_DATE('2024-10-01','YYYY-MM-DD'), TO_DATE('2024-10-10','YYYY-MM-DD'), 'OBJAVLJEN', 0)
    RETURNING ID_IR INTO ir_ostalo;
    INSERT INTO ostali_dokumenti(ID_IR, OPCIJE) VALUES (ir_ostalo, 'PREZENTACIJA');
    INSERT INTO kljucne_reci(ID_IR, KLJUCNA_REC) VALUES (ir_ostalo, 'Konferencija');

    -----------------------------------------------------------------------------------
    -- 5) UREDJUJE
    -----------------------------------------------------------------------------------
    INSERT INTO uredjuje(ID_IR, ID_UREDNIKA) VALUES (ir_dataset, id_u_urednik_nikola);
    INSERT INTO uredjuje(ID_IR, ID_UREDNIKA) VALUES (ir_softver, id_u_urednik_nikola);

    -----------------------------------------------------------------------------------
    -- 6) PUBLIKACIJE
    -----------------------------------------------------------------------------------
    INSERT INTO publikacija(ID_P, ID_D, ID_TI, ID_SA)
    VALUES (SEQ_PUBLIKACIJA.NEXTVAL, ir_dataset, NULL, NULL)
    RETURNING ID_P INTO p_dataset;

    INSERT INTO publikacija(ID_P, ID_D, ID_TI, ID_SA)
    VALUES (SEQ_PUBLIKACIJA.NEXTVAL, NULL, NULL, ir_softver)
    RETURNING ID_P INTO p_softver;

    INSERT INTO publikacija(ID_P, ID_D, ID_TI, ID_SA)
    VALUES (SEQ_PUBLIKACIJA.NEXTVAL, NULL, ir_tehizv, NULL)
    RETURNING ID_P INTO p_tehizv;

    -----------------------------------------------------------------------------------
    -- 7) AUTORSTVO
    -----------------------------------------------------------------------------------
    INSERT INTO autorstvo(ID_U, ID_P, REDNI_BROJ_AUTORA, TIP_DOPRINOSA, ULOGA_U_PUBLIKACIJI)
    VALUES (id_u_autor_marija, p_dataset, 1, 'Prikupljanje i obrada podataka', 'Prvi autor');
    INSERT INTO autorstvo(ID_U, ID_P, REDNI_BROJ_AUTORA, TIP_DOPRINOSA, ULOGA_U_PUBLIKACIJI)
    VALUES (id_u_autor_nikola, p_dataset, 2, 'Statisticka analiza', 'Koautor');

    INSERT INTO autorstvo(ID_U, ID_P, REDNI_BROJ_AUTORA, TIP_DOPRINOSA, ULOGA_U_PUBLIKACIJI)
    VALUES (id_u_autor_nikola, p_softver, 1, 'Razvoj softvera', 'Prvi autor');

    INSERT INTO autorstvo(ID_U, ID_P, REDNI_BROJ_AUTORA, TIP_DOPRINOSA, ULOGA_U_PUBLIKACIJI)
    VALUES (id_u_autor_marija, p_tehizv, 1, 'Terenska merenja', 'Prvi autor');

    -----------------------------------------------------------------------------------
    -- 8) RUNDE RECENZIJE + ANGAZOVANJE RECENZENATA + OCENE
    -----------------------------------------------------------------------------------

    INSERT INTO runda_recenzije(ID_P, ID_UREDNIKA, BROJ_RUNDE, DATUM_ODLUKE, KONACNA_ODLUKA)
    VALUES (p_dataset, id_u_urednik_nikola, 1, TO_DATE('2024-05-20','YYYY-MM-DD'), 'PRIHVACENA');

    INSERT INTO angazovanje_recenzent(ID_P, ID_RECENZENTA, BROJ_RUNDE, PREPORUKA)
    VALUES (p_dataset, id_u_recenzent_ana, 1, 'DA');
    INSERT INTO ocena_recenzenta(ID_O, ID_P, ID_RECENZENTA, BROJ_RUNDE, OCENA)
    VALUES (SEQ_OCENA_RECENZENTA.NEXTVAL, p_dataset, id_u_recenzent_ana, 1, 5);
    INSERT INTO ocena_recenzenta(ID_O, ID_P, ID_RECENZENTA, BROJ_RUNDE, OCENA)
    VALUES (SEQ_OCENA_RECENZENTA.NEXTVAL, p_dataset, id_u_recenzent_ana, 1, 4);

    INSERT INTO angazovanje_recenzent(ID_P, ID_RECENZENTA, BROJ_RUNDE, PREPORUKA)
    VALUES (p_dataset, id_u_recenzent_stefan, 1, 'DA');
    INSERT INTO ocena_recenzenta(ID_O, ID_P, ID_RECENZENTA, BROJ_RUNDE, OCENA)
    VALUES (SEQ_OCENA_RECENZENTA.NEXTVAL, p_dataset, id_u_recenzent_stefan, 1, 4);

    INSERT INTO runda_recenzije(ID_P, ID_UREDNIKA, BROJ_RUNDE, DATUM_ODLUKE, KONACNA_ODLUKA)
    VALUES (p_softver, id_u_urednik_nikola, 1, TO_DATE('2023-12-10','YYYY-MM-DD'), 'POTREBNA_REVIZIJA');

    INSERT INTO angazovanje_recenzent(ID_P, ID_RECENZENTA, BROJ_RUNDE, PREPORUKA)
    VALUES (p_softver, id_u_recenzent_stefan, 1, 'NE');
    INSERT INTO ocena_recenzenta(ID_O, ID_P, ID_RECENZENTA, BROJ_RUNDE, OCENA)
    VALUES (SEQ_OCENA_RECENZENTA.NEXTVAL, p_softver, id_u_recenzent_stefan, 1, 2);

    INSERT INTO runda_recenzije(ID_P, ID_UREDNIKA, BROJ_RUNDE, DATUM_ODLUKE, KONACNA_ODLUKA)
    VALUES (p_softver, id_u_urednik_nikola, 2, TO_DATE('2024-01-18','YYYY-MM-DD'), 'PRIHVACENA');

    INSERT INTO angazovanje_recenzent(ID_P, ID_RECENZENTA, BROJ_RUNDE, PREPORUKA)
    VALUES (p_softver, id_u_recenzent_stefan, 2, 'DA');
    INSERT INTO ocena_recenzenta(ID_O, ID_P, ID_RECENZENTA, BROJ_RUNDE, OCENA)
    VALUES (SEQ_OCENA_RECENZENTA.NEXTVAL, p_softver, id_u_recenzent_stefan, 2, 5);

    -----------------------------------------------------------------------------------
    -- 9) CITAT 
    -----------------------------------------------------------------------------------
    INSERT INTO citat(ID_P1, ID_P2, CITIRAJUCA_PUBLIKACIJA, CITIRANA_PUBLIKACIJA, TIP_CITATA, MESTO_CITIRANJA, KONTEKST_CITIRANJA)
    VALUES (p_softver, p_dataset, 'AnalizaPodatakaLib', 'Klimatski podaci Balkana 2000-2024', 'DIREKTAN', 'Uvod', 'Biblioteka je razvijena i testirana nad ovim skupom podataka');

    COMMIT;
END;
/




