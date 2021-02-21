# Terminplaner Fahrradladen
SOT - Project 6 - J. O., A. P., K. M. (@JohnOldenburger, @Siizu, @cateyeRgr/@cateye0434)

### Project summary: This project's objective is to provide scheduling software for company manpower planning and repair work for better bike workshop management.
### Projekt Übersicht: Mit diesem Projekt wollen wir ein besseres Werkstattmanagement ermöglichen. Dazu erstellen wir eine Software für digitale Reparaturtermine für Kunden und somit Arbeitsplanung für die Mitarbeiter, die durch den Werkstattleiter eingetragen wird.

In der aktuellen Version konzentrieren wir uns, wie in der Projektaufgabe beschrieben, auf die Terminplanung. In zukünftigen Versionen können dann Ansichten der Arbeitszeiten für jeden Mitarbeiter hinzugefügt werden, um diese separat zu verwalten. Außerdem wird dann auch eine Berechnung des Gehalts der Mitarbeiter und eine Kostenrechnung für die Werkstatt möglich sein.

Aktuell enthält die App vier Sichten: Termin anlegen, Termin suchen, Kunde anlegen, Mitarbeiter anlegen


### Termin planen
![TerminAnlegenGUI](https://user-images.githubusercontent.com/74964267/108601350-6e722980-739c-11eb-8f5f-54f3cc918042.PNG)

In der "Termin anlegen"-View befinden sich oben und unten zwei ComboBoxen, in denen man je einen bestehenden Kunden und einen bestehenden Mitarbeiter auswählen und zu einem Termin hinzufügen kann. Mittig befindet sich ein Kalender, in dem man das Datum für den Termin auswählen kann, das aktuelle Datum ist grau hinterlegt, das früheste Datum für einen Termin ist hellblau hinterlegt.
Unter dem Kalender befindet sich TextBoxen zum Eintragen von Uhrzeit und Preis für den Kunden. Ganz unten kann man den neuen Termin durch Drücken eines Buttons speichern oder löschen.

### Termin suchen
![TerminSuchenGUI](https://user-images.githubusercontent.com/74964267/108601353-70d48380-739c-11eb-967e-58c6efc4e039.PNG)

In der "Termin suchen"-Sicht, kann man durch Anklicken eines Tabelleneintrags den entsprechenden Termin auswählen und diesen dann durch Klick auf einen "Löschen"-Button löschen oder durch Klick auf "Ändern" editieren.

### Kunde anlegen
![KundeAnlegenGUI](https://user-images.githubusercontent.com/74964267/108601342-674b1b80-739c-11eb-96ed-060be8f78c3d.PNG)

### Mitarbeiter anlegen
![MitarbeiterAnlegenGUI](https://user-images.githubusercontent.com/74964267/108601345-6a460c00-739c-11eb-8406-2851ca3a3ef4.PNG)

In den Sichten "Kunde anlegen und "Mitarbeiter anlegen" können diese Personengruppen zur Datenbank hinzugefügt werden und sind so in den ComboBoxen der Sicht "Termin anlegen" zur Auswahl für einen Termin verfügbar. Auch hier kann man über Klick auf einen von zwei Buttons speichern oder löschen.

Außerdem haben wir in unserer Datenbank in der Tabelle für die Mitarbeiter die Spalte "Supervisor" eingefügt, so dass zukünftig ein Rechtemanagement möglich ist, damit nur der Werkstattleiter über eine Login-GUI zugriff auf die Planung hat.

Auch können zukünftig Ersatzteile in der Datenbank angelegt werden, es ist bereits eine Tabelle hierfür vorhanden. Diese können dann zu den Kosten der Werkstatt für Arbeitslöhne addiert werden, so dass der Werkstattleiter einen Überblick über seine Ausgaben hat.

Es wird eine Berechnung der genauen Kosten durch die Felder "AppointmentPrice" in der Appointmenttabelle und "Hours" sowie "Wage" in der Mitarbeitertabelle möglich sein. (Summe aller AppointmentPrices + Summe aller ((Hours*Wage)pro Mitarbeiter)

Einnahmen kann der Werkstattleiter über das Feld AppointmentPrice in Appointment einsehen und so durch Vergleich mit den Kosten durch Gehälter und Ersatzteile eine Gewinn-Verlust-Rechnung durchführen.

