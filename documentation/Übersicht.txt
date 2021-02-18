# bike-shop-scheduler
SOT - Project 6 - J. Oldenburger, A. Peters, K. Müller 

Project summary: This project's objective is to provide scheduling software for company manpower planning and repair work for better bike workshop management.

Projekt Übersicht: Mit diesem Projekt wollen wir ein besseres Werkstattmanagement ermöglichen. Dazu erstellen wir eine Software für digitale Reparaturtermine für Kunden und somit Arbeitsplanung für die Mitarbeiter, die durch den Werkstattleiter eingetragen wird.


In der aktuellen Version konzentrieren wir uns, wie in der Projektaufgabe beschrieben, auf die Terminplanung. In zukünftigen Versionen können dann Ansichten der Arbeitszeiten für jeden Mitarbeiter hinzugefügt werden, um diese separat zu verwalten.

Außerdem haben wir in unserer Datenbank in der Tabelle für die Mitarbeiter die Spalte "Supervisor" eingefügt, so dass zukünftig ein Rechtemanagement möglich ist, damit nur der Werkstattleiter über eine Login-GUI zugriff auf die Planung hat.

Auch können zukünftig Ersatzteile in der Datenbank angelegt werden, es ist bereits eine Tabelle hierfür vorhanden. Diese können dann zu den Kosten der Werkstatt für Arbeitslöhne addiert werden, so dass der Werkstattleiter einen Überblick über seine Ausgaben hat.

Es wird eine Berechnung der genauen Kosten durch die Felder "AppointmentPrice" in der Appointmenttabelle und "Hours" sowie "Wage" in der Mitarbeitertabelle möglich sein. (Summe aller AppointmentPrices + Summe aller ((Hours*Wage)pro Mitarbeiter)

Einnahmen kann der Werkstattleiter über das Feld AppointmentPrice in Appointment einsehen und so durch Vergleich mit den Kosten durch Gehälter und Ersatzteile eine Gewinn-Verlust-Rechnung durchführen.

