    -- SkriptaZaBazu.sql

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
            ID_IR NUMBER(10) PRIMARY KEY,
            BROJ_VERZIJE NUMBER(10) NOT NULL,
            DATUM_POSTAVLJANJA DATE NOT NULL,
            OPIS_IZMENA VARCHAR2(500) NOT NULL,
            ODGOVORNA_OSOBA VARCHAR2(100) NOT NULL,

            --Ima--
            CONSTRAINT FK_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
        );

            --Pripadajuci fajlovi atributi
            CREATE TABLE pripadajuci_fajlovi(
                
                ID_V NUMBER(10) NOT NULL,
                NAZIV_FAJLA VARCHAR2(100) NOT NULL,

                CONSTRAINT PK_PRIPADAJUCI_FAJLOVI PRIMARY KEY (ID_V, NAZIV_FAJLA),
                CONSTRAINT FK_ID_V FOREIGN KEY (ID_V) REFERENCES verzija(ID_V) ON DELETE CASCADE
            );

    --podklase istrazivackih rezultata
    CREATE TABLE ostali_dokumenti(
        ID_IR NUMBER(10) PRIMARY KEY,
        OPCIJE VARCHAR2(100) NOT NULL,

        CONSTRAINT FK_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
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
        CREATE TABLE podrzane_platforma(
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
    -----------------------------------------------------------------------------------------------------------
    -- Kreiranje tabele za Uloge

    CREATE TABLE uloga(
        ID_U NUMBER(10) PRIMARY KEY
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
            ID_U NUMBER(10) PRIMARY KEY,
            OVLASCENJE VARCHAR2(100) NOT NULL,
            CONSTRAINT FK_ADMINISTRATOR_OVLASCENJA_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
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

        CONSTRAINT CHK_ORCID CHECK (REGEXP_LIKE(ORCID, '^\d{4}-\d{4}-\d{4}-\d{3}[\dX]$')),
        CONSTRAINT FK_AUTOR_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U) ON DELETE CASCADE
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
        ID_U NUMBER(10) NOT NULL,

        CONSTRAINT FK_ID_U FOREIGN KEY (ID_U) REFERENCES uloga(ID_U),
        CONSTRAINT CHK_STATUS_NAUCNIKA CHECK (STATUS_NAUCNIKA IN ('AKTIVAN','NEAKTIVAN'))
    );

        -- Mail I Telefoni atributi
        CREATE TABLE mail(
            ID_I NUMBER(10) PRIMARY KEY,
            MAIL VARCHAR2(100) NOT NULL,

            CONSTRAINT CHK_MAIL CHECK (REGEXP_LIKE(MAIL, '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$')),
            CONSTRAINT FK_MAIL_ID_I FOREIGN KEY (ID_I) REFERENCES istrazivac(ID_I) ON DELETE CASCADE
        );

        CREATE TABLE telefon(
            ID_I NUMBER(10) PRIMARY KEY,
            TELEFON VARCHAR2(20) NOT NULL,

            CONSTRAINT CHK_TELEFON CHECK (REGEXP_LIKE(TELEFON, '^\+?[0-9]{10,15}$')),
            CONSTRAINT FK_TELEFON_ID_I FOREIGN KEY (ID_I) REFERENCES istrazivac(ID_I) ON DELETE CASCADE
        );

    --------------------------------------------------------------------------------------------------------------
    -- Kreiranje tabele za Naucnoistraživačke Institucije

    CREATE TABLE ni_institucija(
        ID_NII NUMBER(10) PRIMARY KEY,
        NAZIV VARCHAR2(100) NOT NULL,
        ADRESA VARCHAR2(200) NOT NULL
    );

        --Naucne Oblasti I Kontakti atributi

        CREATE TABLE naucna_oblast(
            ID_NII NUMBER(10) PRIMARY KEY,
            NAUCNA_OBLAST VARCHAR2(100) NOT NULL,

            CONSTRAINT FK_NAUCNA_OBLAST_ID_NII FOREIGN KEY (ID_NII) REFERENCES ni_institucija(ID_NII) ON DELETE CASCADE
        );

        CREATE TABLE mail_institucija(
            ID_NII NUMBER(10) PRIMARY KEY,
            MAIL VARCHAR2(100) NOT NULL,

            CONSTRAINT CHK_MAIL_INSTITUCIJA CHECK (REGEXP_LIKE(MAIL, '^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$')),
            CONSTRAINT FK_MAIL_ID_NII FOREIGN KEY (ID_NII) REFERENCES ni_institucija(ID_NII) ON DELETE CASCADE
        );

        CREATE TABLE telefon_institucija(
            ID_NII NUMBER(10) PRIMARY KEY,
            TELEFON VARCHAR2(20) NOT NULL,

            CONSTRAINT CHK_TELEFON_INSTITUCIJA CHECK (REGEXP_LIKE(TELEFON, '^\+?[0-9]{10,15}$')),
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
        ID_IR NUMBER(10) NOT NULL,

        CONSTRAINT FK_PUBLIKACIJA_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE
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
        ID_UREDNIKA NUMBER(10) NOT NULL,
        ID_RECENZENTA NUMBER(10) NOT NULL,
        BROJ_RUNDE NUMBER(10) NOT NULL,
        DATUM_ODLUKE DATE NOT NULL,
        KONACNA_ODLUKA VARCHAR2(20) DEFAULT 'POTREBNA_REVIZIJA' NOT NULL,

        CONSTRAINT PK_RR PRIMARY KEY (ID_P,ID_RECENZENTA,ID_UREDNIKA,BROJ_RUNDE),
        --Angazovanje urednika i runde recenzije (1:N)
        CONSTRAINT FK_RR_ID_UREDNIKA FOREIGN KEY (ID_UREDNIKA) REFERENCES urednik(ID_U) ON DELETE CASCADE,
        CONSTRAINT FK_RR_ID_RECENZENTA FOREIGN KEY (ID_RECENZENTA) REFERENCES recenzent(ID_U) ON DELETE CASCADE,
        CONSTRAINT FK_RR_ID_P FOREIGN KEY (ID_P) REFERENCES publikacija(ID_P) ON DELETE CASCADE,
        CONSTRAINT CHK_KONACNA_ODLUKA CHECK (KONACNA_ODLUKA IN ('POTREBNA_REVIZIJA','PRIHVACENA','ODBIJENA'))
    );

        --Angazovanje recenzenti
        CREATE TABLE angazovanje_recenzent(
            ID_P NUMBER(10) NOT NULL,
            ID_RECENZENTA NUMBER(10) NOT NULL,
            PREPORUKA VARCHAR2(10) DEFAULT 'NE' NOT NULL,

            CONSTRAINT CHK_PREPORUKA CHECK (PREPORUKA IN ('DA','NE')),
            CONSTRAINT PK_ANG_REC PRIMARY KEY (ID_P, ID_RECENZENTA),
            CONSTRAINT FK_ANG_REC_ID_P FOREIGN KEY (ID_P) REFERENCES publikacija(ID_P) ON DELETE CASCADE,
            CONSTRAINT FK_ANG_REC_ID_REC FOREIGN KEY (ID_RECENZENTA) REFERENCES recenzent(ID_U) ON DELETE CASCADE
        );
        
            --Ocena recenzenta atribut
            CREATE TABLE ocena_recenzenta(
                ID_P NUMBER(10) NOT NULL,
                ID_RECENZENTA NUMBER(10) NOT NULL,
                BROJ_RUNDE NUMBER(10) NOT NULL,
                OCENA NUMBER(1) NOT NULL,

                CONSTRAINT CHK_OCENA CHECK (OCENA BETWEEN 1 AND 5),
                CONSTRAINT PK_OCENA PRIMARY KEY (ID_P, ID_RECENZENTA,BROJ_RUNDE,OCENA),
                CONSTRAINT FK_OCENA_ID_P FOREIGN KEY (ID_P) REFERENCES publikacija(ID_P) ON DELETE CASCADE,
                CONSTRAINT FK_OCENA_ID_REC FOREIGN KEY (ID_RECENZENTA) REFERENCES recenzent(ID_U) ON DELETE CASCADE
            );
-------------------------------------------------------------------------------------------------------------------
-- Ureduje
    CREATE TABLE ureduje(
        ID_IR NUMBER(10) NOT NULL,
        ID_UREDNIKA NUMBER(10) NOT NULL,

        CONSTRAINT PK_UREDI PRIMARY KEY (ID_IR, ID_UREDNIKA),
        CONSTRAINT FK_UREDI_ID_IR FOREIGN KEY (ID_IR) REFERENCES istrazivacki_rezultat(ID_IR) ON DELETE CASCADE,
        CONSTRAINT FK_UREDI_ID_UREDNIKA FOREIGN KEY (ID_UREDNIKA) REFERENCES urednik(ID_U) ON DELETE CASCADE
    );
