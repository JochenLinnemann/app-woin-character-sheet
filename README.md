# app-woin-character-sheet
A Character Sheet App for the WOIN RPG

---

This work includes material taken from the WOIN Rules Reference Document (WRRD)
by EN Publishing and available at https://www.woinrules.com, based on the
What's OLD is NEW (WOIN) game system available at https://www.woinrpg.com.
The WRRD is licensed under the Creative Commons Attribution 4.0 International
License available at https://creativecommons.org/licenses/by/4.0/legalcode.

---

Adding TailwindCSS Support: https://codewithmukesh.com/blog/integrating-tailwind-css-with-blazor/

---

## Development

Develop using the CharacterSheet.Web project; in two consoles run:
1. `dotnet watch`
2. `npm run buildcss -- --watch`

This enables full hot reload and provides faster feedback than MAUI hot-reload.

---

## Requirements

- a Character has:
  - 9 or 10 Attributes (https://www.woinrules.com/characters/attributes) - which are:
    - Strength or STR
    - Agility or AGI
    - Endurance or END
    - Intuition or INT
    - Logic or LOG
    - Willpower or WIL
    - Charisma or CHA
    - Luck or LUC
    - Reputation or REP
    - optionally: Power or POW - depending on setting, one of:
      - Magic or MAG
      - Chi or CHI
      - Psionics or PSI
  - 1 Heritage (https://www.woinrules.com/characters/heritages) provides
    - Attribute Adjustments
    - 3 Heritage Skills
    - Heritage Exploits
  - 1 Hook as part of 1 Descriptor (https://www.woinrules.com/characters/descriptor)
    - ...
  - Careers (https://www.woinrules.com/characters/careers)
    - Attribute Adjustments
    - 2 Career Skills or Defensive Skills
    - 1 Career Exploit
    - Age Increase
  - Exploits (https://www.woinrules.com/characters/universal-exploits)
    - Aim, Feint, or Focus
    - 1 other Exploit for which the character qualifies
  - 1 Trait (https://www.woinrules.com/characters/traits)
    - based on highest or lowest attribute
  - 1 Age (https://www.woinrules.com/characters/age)
  - Derived Statistics (https://www.woinrules.com/characters/derived-statistics)
    - ...
  - Equipment (https://www.woingear.com/)
    - ...
