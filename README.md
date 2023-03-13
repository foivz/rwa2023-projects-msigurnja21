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

Troškovi bi se unosili u stupcima. Vrijednosti bi bile: šifra, iznos potrošenog novca, komentar uz transakciju.
Troškovi bi trebali biti kateogrizirani po vrsti. Na primjer hrana i piće je broj 1, podkategorija je pekara i ona je broj 11, kada bi bilo potrebe za novom podkategorijom bila bi 12.. 

Potrebno je omogućiti unos mjesečne plaće kako bi se prikazala statistika i predviđanje koliko bi novaca imala do kraja mjeseca i koliko dana ima do nule na računu prema prosječnoj dnevnoj potrošnji.


## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti. Također uzmite u obzir da je u ovom trenutku dovoljno opisati 3 funkcionalnosti, dok će sve funkcionalnoisti biti pobrojane u sklopu rada na projektu i specifikacija zahtjeva. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:


Oznaka | Naziv | Kratki opis 
------ | ----- | ----------- 
F01 | Login | Za pristup alatu za praćenje osobnih financije potrebna je autentikacija korisnika pomoću login funkcionalnosti. Korisnik sam kreira korisničko ime i lozinku pri prvom pokretanju aplikacije. Opcija login bi se trebala isključiti po potrebi.
F02 | Unos prihoda i troškova |  Korisnik bi trebao biti u mogućnosti unijeti troškove uz opis i kategoriju.
F03 | Prikaz prihoda i troškova | Korisniku bi se trebalo omogućiti prikaz svih prihoda i troškova .
F04 | Predviđanje | Potrebno je omogućiti korisniku predviđanje na temelju prosječne dnevne potrošnje koliko bi novaca ostalo do kraja mjeseca ili koliko je dana potrebno do nule na računu.

## Tehnologije i oprema
Umjesto ovih uputa jasno popišite sve tehnologije, alate i opremu koju ćete koristiti pri implementaciji vašeg rješenja. Projekti se razvijaju koristeći .Net Framework ili .Net Core razvojne okvire, a vrsta projekta može biti WinForms, WPF i UWP. Ne zaboravite planirati korištenje tehnologija u aktivnostima kao što su projektni menadžment ili priprema dokumentacije. Tehnologije koje ćete koristiti bi trebale biti javno dostupne, a ako ih ne budemo obrađivali na vježbama u vašoj dokumentaciji ćete morati navesti način preuzimanja, instaliranja i korištenja onih tehnologija koje su neopbodne kako bi se vaš programski proizvod preveo i pokrenuo. Pazite da svi alati koje ćete koristiti moraju imati odgovarajuću licencu. Što se tiče zahtjeva nastavnika, obvezno je koristiti git i GitHub za verzioniranje programskog koda, GitHub Wiki za pisanje tehničke i projektne dokumentacije, a projektne zadatke je potrebno planirati i pratiti u alatu GitHub projects. 
