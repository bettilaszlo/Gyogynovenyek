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
     - Egyébként: 12 - Vég + Kezdet + 1
## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be:
  - System.IO
  - StreamReader
  - while ciklussal --> alíg tart a fájl
  - Cikluson belül listához hozzáadunk egy új objektum példányt (beolvasott sor a paraméter)
## 1. feladat
- Hány nővény van --> lista.Count (tulajdonság)
## 2. feladat
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből?
## 3. feladat
- Maximum keresés --> Időtartam alapján
- Nővény(ek) amely(ek) a legtöbb ideig szedhetőek
## 4. feladat
- Időtartam átlag számítás (Összegzés)  

