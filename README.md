# bike-shop-scheduler
SOT - Project 6 - J. O., A. P., K. M. 

Project summary: This project's objective is to provide scheduling software for company manpower planning and repair work for better bike workshop management.
Projekt Übersicht: Mit diesem Projekt wollen wir ein besseres Werkstattmanagement ermöglichen. Dazu erstellen wir eine Software für digitale Reparaturtermine für Kunden und somit Arbeitsplanung für die Mitarbeiter, die durch den Werkstattleiter eingetragen wird.

In der aktuellen Version konzentrieren wir uns, wie in der Projektaufgabe beschrieben, auf die Terminplanung. In zukünftigen Versionen können dann Ansichten der Arbeitszeiten für jeden Mitarbeiter hinzugefügt werden, um diese separat zu verwalten.

Die App enthält vier Sichten: Termin anlegen, Termin suchen, Kunde anlegen, Mitarbeiter anlegen
In der "Termin anlegen"-View befinden sich oben und unten zwei ComboBoxen, in denen man je einen bestehenden Kunden und einen bestehenden Mitarbeiter auswählen und zum Termin hinzufügen kann. Mittig befindet sich ein Kalender, in dem man das Datum für den Termin auswählen kann, das aktuelle Datum ist grau hinterlegt, das früheste Datum für einen Termin ist hellblau hinterlegt.
Unter dem Kalender befindet sich TextBoxen zum Eintragen von Uhrzeit und Preis für den Kunden. Ganz unten kann man den neuen Termin durch Drücken eines Buttons speichern oder löschen.

In der "Termin suchen"-Sicht, kann man Termine auswählen, die dann durch Klick auf einen von zwei Button geändert oder gelöscht werden.
In den Sichten "Kunde anlegen und "Mitarbeiter anlegen" können diese Personengruppen zur Datenbank hinzugefügt werden und sind so in den ComboBoxen der Sicht "Termin anlegen" zur Auswahl für einen Termin verfügbar. Auch hier kann man über Klick auf einen von zwei Buttons speichern oder löschen.

Außerdem haben wir in unserer Datenbank in der Tabelle für die Mitarbeiter die Spalte "Supervisor" eingefügt, so dass zukünftig ein Rechtemanagement möglich ist, damit nur der Werkstattleiter über eine Login-GUI zugriff auf die Planung hat.

Auch können zukünftig Ersatzteile in der Datenbank angelegt werden, es ist bereits eine Tabelle hierfür vorhanden. Diese können dann zu den Kosten der Werkstatt für Arbeitslöhne addiert werden, so dass der Werkstattleiter einen Überblick über seine Ausgaben hat.

Es wird eine Berechnung der genauen Kosten durch die Felder "AppointmentPrice" in der Appointmenttabelle und "Hours" sowie "Wage" in der Mitarbeitertabelle möglich sein. (Summe aller AppointmentPrices + Summe aller ((Hours*Wage)pro Mitarbeiter)

Einnahmen kann der Werkstattleiter über das Feld AppointmentPrice in Appointment einsehen und so durch Vergleich mit den Kosten durch Gehälter und Ersatzteile eine Gewinn-Verlust-Rechnung durchführen.

