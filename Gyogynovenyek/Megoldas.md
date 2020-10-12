# Megoldás
# Osztály létrehozása
- Kétféle mód közül bármelyik:
    - Ctrl + .
    - Adjunk hozzá osztályt
- 5 tulajdonság
   - public get
   - private set
- 1 konstruktor
    - 1 paraméter --> String
    - Pl: "Acsalapu;levél;6;8"
    - ;-vel vannak elválasztva
    - 4 darab adat --> 5 tulajdonság?
    - Átadott, fájlból beolvasott sort:
       - ';' mentén tagoljuk
       - [0] --> Nev
       - [1] --> Resz
       - [2] --> Kezd
       - [3] --> Veg
       - Idotartam --> számolás (lásd következő pont)
- 5-dik tulajdonság --> Időtartam
     - Konstruktorban számljuk 
     - Számolása: Vég - kezdet HA!!! Vég > Kezdet
     - Vég > Kezdet --> Vég - Kezdet + 1
     - Egyébként: 12 - Kezdet + Vég + 1
## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be:
  - System.IO
  - StreamReader
  - while ciklussal --> alíg tart a fájl
  - Cikluson belül listához hozzáadunk egy új objektum példányt (beolvasott sor a paraméter)
## 1. feladat
- Hány növény van --> lista.Count (tulajdonság)
## 2. feladat
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből?
- Adatszerk.: Dictionary<string, int>
- 1 Milyen gyűjthető részek vannak
     - Foreach a "novenyek"-en
     - Ha a rész nem kulcs --> akkor adjuk hozzá 0-val
- Hány darab van ezekből
  - Foreach "novenyek"
  - Ha "Resz" == Key 
## 3. feladat
- Maximum keresés --> Időtartam alapján
  - maximum változó =0
  - foreach novenyek
  - ha max < Idotarta  --> max = Idotartam
- Nővény(ek) amely(ek) a legtöbb ideig szedhetőek
  - Foreach novenyek
  - Kiirni ha Idotartam == max
## 4. feladat
- Időtartam átlag számítás (Összegzés)  
  - szum változó =0
  - atlag változó
  - foreach novenyek
  - szum += Idotartam
  - atlag = szum / Count

