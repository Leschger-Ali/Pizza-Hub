# Pizza Hub — Windows Forms Demo

> A demo C# Windows Forms app that **simulates** a pizza ordering flow. This is **not** a real ordering system.

## Features
- Choose **size**: Small / Medium / Large / Extra Large  
- Choose **crust**: Thin / Regular / Thick / Stuffed  
- Multiple **toppings** via checkboxes (e.g., Extra Cheese, Onions, Mushrooms, Peppers, Jalapeños)  
- **Where to eat**: Eat in / Takeaway / Delivery (shows address fields)  
- **Live order summary** reflecting current selections  
- **Quantity** selector with **instant total price** calculation  
- Actions: **Confirm Order** and **Reset**

## Tech Stack
- **C# .NET — Windows Forms**
- UI controls: `RadioButton`, `CheckBox`, `TextBox`, `Label`, `Button`
- Simple in-form logic for pricing (base by size + per-topping × quantity)  
- No backend / No database

## How to Run
1. Open the solution in **Visual Studio 2022+** (Windows).  
2. Build and run (**F5**).  
3. Make selections and observe the live summary & total price.

## Screenshots
- Main UI with live total:  
  <img width="1239" height="773" alt="Screenshot 2025-08-20 055054" src="https://github.com/user-attachments/assets/e3e61600-4c84-482c-8c40-0b6b8e2e9f65" />

- (Optional) Initial state:  
  <img width="1238" height="773" alt="image" src="https://github.com/user-attachments/assets/c70335b9-3af1-4937-a340-d8fcc936ab3d" />



## Notes / Roadmap
- Persist orders and print receipt
- Database integration
- Configurable price list
- Basic input validation improvements

---

## Kurzbeschreibung (Deutsch)

**Pizza Hub** ist eine **Demo-Anwendung** in C# (Windows Forms), die einen Pizzabestell-Ablauf **simuliert**.  
Funktionen: Auswahl von Größe, Teig und Belägen, Eat-in/Takeaway/Delivery (mit Adressfeldern), Live-Bestellübersicht, Mengenwahl und automatische Gesamtsumme.  
**Hinweis:** Reines UI-Prototype, **kein** echtes Bestellsystem.

