1 Jak spustit
do konzole : dotnet run --project=Contact
nebo spustit skrze Visual Studio nebo Rider


2 Přehled
    2.1 Hlavní stránka
       Na hlavní stránce jsou 3 důležité části
       1) search bar
            prázdný search bar = list všech kontaktů
            vyplněný search bar = najde kontatky kde jméno nebo telefon nebo email obsahuje hledaný text
       
       2) List kontaků
            každý kontakt má 2 tlačítka
            detail - otevře podrobnější detail kontaktu s tlačítkem upravit
            delete
            
       3) Tlačítka pro přidání kontaktu a smazání všech kontaktů
       
       
    2.2 Formulář úpravy/ přidání
        obsahuje 4 pole
            first name
            last name
            phone number
            email
        
        email nebo phone number jsou povinné
        first name a last name mohou být prázdné
        
        email musí splňovat RFC 5322 standard
        pro phone number stačí 2-15 číslic
        
        na spodu je tlačítko save/create
        delete (pokud se upravuje existující kontakt)
        go back (návrat na hlavní stránku)
        
    2.3 databáze
        aplikace používá sqlite
        
        existuje mock db kterou jsem používal než jsem implementoval ef
        v kódu už se nepoužívá
        interface IDataSource existuje aby šlo mock db zaměnit za jinou db změněním jedné řádky v DatabaseUtility
        IDataSource má metody connect a close connection protože jsem zapoměl že c# ef je nemá
        
        