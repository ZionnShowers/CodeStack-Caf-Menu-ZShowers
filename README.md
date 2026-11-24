- Zionn Showers
- 11/24/2026
- CodeStack Cafe Menu
- Our goal was to make a web page based on the images we were given and try to make it user friendly for desktop and mobile users while fetching data from the api db.
- Reviewer: Chris Estrada
- Peer Reviewer: everything looks great and fits all screen sizes. js is clean and functional and it looks just like the picture. nicely done!

# CodeStack Café Menu

Build the online menu for the **CodeStack Café**. All of the menu info (names, prices, descriptions, categories) comes from an API. The photos are in the `images/` folder.

## The challenge

Build a page that looks as close to the design as you can and:

- Gets the menu data from the API with `fetch()`
- Shows the restaurant's name, tagline and info
- Shows a nav link for each category that jumps to that section
- Shows a section for each category with only that category's items
- Shows a card for each item with its photo, name, price, description and tag
- Shows prices as `$0.00`
- Shows a loading message, and an error message if the fetch fails
- Looks good on phones and on laptops

## What's in this folder

| File | What it is |
|---|---|
| `index.html` | The starting page. Tailwind and the fonts are already set up. |
| `script.js` | Empty. Write all your JavaScript here. |
| `images/` | The food photos. Each one is named after its item's `id`. |
| `design-desktop.png` | What the finished page looks like on a laptop |
| `design-mobile.png` | What the finished page looks like on a phone |
| `style-guide.md` | Colors, fonts and design sizes |

The API is at `../api/menu.json`.

## Rules

- Don't type any menu info into your HTML. It all comes from the API.
- Style with Tailwind classes only, no custom CSS.

## Getting started

1. Open the `menu-assignment` folder in VS Code.
2. Start **Live Server** and go to `/starter/index.html`. (`fetch()` won't work if you just double-click the file.)
3. Fetch the data and `console.log` it to see what you're working with.
4. Get everything on the page, then make it look like the design.

