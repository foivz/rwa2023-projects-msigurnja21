# Inicijalne upute za prijavu projekta iz Razvoja Windows aplikacija

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Razvoj Windows proizvoda, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **kratko opisati projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. Mentor će vam slati povratne informacije kroz sekciju Discussions također dostupnu na GitHubu vašeg projekta. A sada, vrijeme je da opišete vaš projekt. Za opis vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta
Alat za praćenje osobnih financija

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Magdalena Sigurnjak | msigurnja21@foi.hr | 0016155027 | msigurnja21

## Opis domene
Domena ove aplikacije je osobne financije. S obzirom na inflaciju i prijelaz na euro, sve je teže pratiti osobnu potrošnju i kontrolirati financije. Stoga je potrebno kreirati sustav koji omogućava unos prihoda i troškova te bolju preglednost gdje se novac najviše troši i gdje bi trebalo smanjiti potrošnju.

Klijentica trenutno evidentira troškove u bilješkama na mobitelu, što otežava snalaženje jer ima preko 200 bilješki. Stoga bi bila korisna jednostavna aplikacija na laptopu koja omogućava pregled troškova kategoriziranih po vrsti.

Kako bi se spriječilo neovlašteno korištenje aplikacije, potrebno je uključiti sustav prijave koji bi se mogao uključiti po potrebi. Također bi bilo poželjno podatke držati u vanjskoj bazi podataka kako bi se spriječilo brisanje u slučaju virusa.

Kako bi se uštedjelo vrijeme i trud, moguće je omogućiti automatsko učitavanje dosadašnjih 200 bilješki iz CSV datoteke u program. Troškovi bi se unosili u stupcima sa šifrom, iznosom potrošenog novca i komentarom uz transakciju. Troškovi bi trebali biti kategorizirani po vrsti i podkategoriji. Na primjer, hrana i piće bi bili broj 1, a podkategorija pekara bi bila broj 11. U slučaju potrebe za novom podkategorijom, dodijelio bi se broj 12.

Kako bi se prikazala statistika i predviđanje koliko bi novaca bilo preostalo do kraja mjeseca i koliko dana ima do nule na računu prema prosječnoj dnevnoj potrošnji, potrebno je omogućiti unos mjesečne plaće. Ovaj sustav bi pomogao korisnicima u boljoj kontroli financija i planiranju budućih rashoda.


## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti. Također uzmite u obzir da je u ovom trenutku dovoljno opisati 3 funkcionalnosti, dok će sve funkcionalnoisti biti pobrojane u sklopu rada na projektu i specifikacija zahtjeva. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:


Oznaka | Naziv | Kratki opis 
------ | ----- | ----------- 
F01 | Login | Za pristup alatu za praćenje osobnih financije potrebna je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se prijavljuje s podacima koji su mu dodjeljeni. Opcija login bi se trebala isključiti i uključiti po potrebi.
F02 | Unos troškova |  Korisnik bi trebao biti u mogućnosti unijeti troškove uz opis i kategoriju.
F03 | Prikaz troškova | Korisniku bi se trebalo omogućiti prikaz svih troškova, troškova po vrsti i vremenskom periodu.
F04 | Unos mjesečne plaće | Omogućiti unos mjesečne plaće kako bi se moglo napraviti predviđanje.
F05 | Predviđanje | Potrebno je omogućiti korisniku predviđanje na temelju prosječne dnevne potrošnje koliko bi novaca ostalo do kraja mjeseca ili koliko je dana potrebno do nule na računu.
F06 | Vanjska baza podataka | Potrebno je napraviti vanjsku bazu podataka kako bi podaci bili sigurniji i ne bi ovisili o laptopu.
F07 | Učitavanje podataka iz CSV datoteke | Omogućiti automatsko učitavanje dosadašnjih 200 bilješki iz CSV datoteke.
F08 | Statistika | Potrebno je napraviti statistiku koja prikazuje kako se količina novčanih sredstava smanjuje tijekom mjeseca.

## Tehnologije i oprema 
Visual Studio Community 2022, Online Gantt, Microsoft Excel, GitHub, GitHub Wiki, GitHub projects

