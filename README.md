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

Zbog inflacije i prelaska na euro postaje sve teže pratiti osobnu potrošnju, odnosno troši li se previše ili premalo. Potrebno je kreirati sustav u koji bi se unosili prihodi i troškovi, te koji bi omogućavao bolju preglednost gdje se novac najviše troši i gdje bi trebalo smanjiti potrošnju.

Klijentica trenutno evidentira troškove u bilješkama na mobitelu, međutim već ih ima preko 200 i teško joj se snalaziti, voljela bi da postoji jednostavna aplikacija na laptopu koja omogućava pregled troškova kategoriziranih po vrsti.

S obzirom da njen mlađi brat svaki drugi vikend igra igrice na njenom laptopu, trebala bi imati sustav prijave koji se može uključiti po potrebi. Također bilo bi dobro podatke držati u vanjskoj bazi podataka kako se u slučaju virusa ne bi sve obrisalo.

Poželjno je omogućiti automatsko učitavanje dosadašnjih 200 bilješki iz CSV datoteke u program, to bi uštedjelo puno vremena i truda.

Troškovi bi se unosili u stupcima. Vrijednosti bi bile: šifra, iznos potrošenog novca, komentar uz transakciju. Troškovi bi trebali biti kateogrizirani po vrsti. Na primjer hrana i piće je broj 1, podkategorija je pekara i ona je broj 11, kada bi bilo potrebe za novom podkategorijom bila bi 12..

Potrebno je omogućiti unos mjesečne plaće kako bi se prikazala statistika kako se novac smanjuje tijekom mjeseca i predviđanje koliko bi novaca imala do kraja mjeseca i koliko dana ima do nule na računu prema prosječnoj dnevnoj potrošnji.


## Specifikacija projekta

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

