import { itemsFetch } from "./dataservices.js";
const baseURL = "http://localhost:5292/api"

const address = document.getElementById("address");
const dates = document.getElementById("dates");
const phone = document.getElementById("phone");
const restName = document.getElementById("restaurant-name");
const tagline = document.getElementById("tagline");
const categoryNav = document.getElementById("category-nav");
const menu = document.getElementById("menu");
const status = document.getElementById("status");
const footerName = document.getElementById("footer-name");
const footerInfo = document.getElementById("footer-info");

const category1Btn = document.getElementById("category1-btn");
const category2Btn = document.getElementById("category2-btn");
const category3Btn = document.getElementById("category3-btn");
const category4Btn = document.getElementById("category4-btn");

const category1Area = document.getElementById("category1-area");
const category2Area = document.getElementById("category2-area");
const category3Area = document.getElementById("category3-area");
const category4Area = document.getElementById("category4-area");

const category1Name = document.getElementById("category1-name");
const category2Name = document.getElementById("category2-name");
const category3Name = document.getElementById("category3-name");
const category4Name = document.getElementById("category4-name");

const category1Num = document.getElementById("category1-num");
const category2Num = document.getElementById("category2-num");
const category3Num = document.getElementById("category3-num");
const category4Num = document.getElementById("category4-num");

//Grab database items
const getItems = async (item) => {
    const res = await fetch(baseURL + "/item", {
        method: "GET",
        //Tell the API the body is JSON.
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(item)
    })
    const data = await res.json();
    console.log(data)
    // boot1picture.src = `${data[0].image_Url}`
    // boot1name.textContent = `${data[0].name}`
    // boot1desc.textContent = `${data[0].description}`
    // boot1tag.textContent = `${data[0].tag}`

    // boot2picture.src = `${data[1].image_Url}`
    // boot2name.textContent = `${data[1].name}`
    // boot2desc.textContent = `${data[1].description}`
    // boot2tag.textContent = `${data[1].tag}`

    // boot3picture.src = `${data[2].image_Url}`
    // boot3name.textContent = `${data[2].name}`
    // boot3desc.textContent = `${data[2].description}`
    // boot3tag.textContent = `${data[2].tag}`
}

getItems();

const showItems = (items) => {

    items.forEach((item) => {
        console.log(item)
        status.textContent = "";

        // const section = document.createElement("div");
        // section.classList = "flex flex-col";

        const div = document.createElement("div");
        // div.classList = "flex";
        div.classList = "mr-8 mb-8 flex-col";

        const line = document.createElement("div");
        line.classList = "flex justify-between"

        const blank = document.createElement("p");
        // blank.textContent = ``;
        blank.classList = "border-b border-[#78716C] border-dotted flex-1 max-h-[18px] "

        const itemImg = document.createElement("img");
        itemImg.src = `${item.image_Url}`
        itemImg.width = "300"

        const itemName = document.createElement("p");
        itemName.textContent = `${item.name}`;
        itemName.classList = "text-[16px] font-semibold mr-2"

        const itemDesc = document.createElement("p");
        itemDesc.textContent = `${item.description}`;
        itemDesc.classList = "text-[12px] font-normal text-[#57534E] max-w-[280px] "

        const itemPrice = document.createElement("p");
        itemPrice.textContent = `$${item.price}.00`;
        itemPrice.classList = "text-[12px] font-semibold text-[#C2410C] mt-1 ml-2"

        const itemTag = document.createElement("p");
        itemTag.textContent = `${item.tag}`.toUpperCase();
        itemTag.classList = "flex justify-center max-w-[100px] bg-[#E7E5E4] rounded-full text-[12px] font-semibold text-[#57534E] p-1 px-3"

        div.appendChild(itemImg);

        div.appendChild(line);

        line.appendChild(itemName);
        line.appendChild(blank);
        line.appendChild(itemPrice);

        div.appendChild(itemDesc);

        div.appendChild(itemTag);

        // div.appendChild(section);

        // const categories = "item.category";
        // category[categories]Area.appendChild(div);
        if (item.category_Id == 1) {
            category1Area.appendChild(div);
        } else if (item.category_Id == 2) {
            category2Area.appendChild(div);
        } else if (item.category_Id == 3) {
            category3Area.appendChild(div);
        } else {
            category4Area.appendChild(div);
        }
        // console.log(item.category_Id)

    });
}

const loadItems = async () => {
    try {
        const data = await itemsFetch();
        showItems(data);
    } catch (error) {
        status.textContent = "Couldn't load items. Check the console."
        category1Btn.textContent = ""
        category2Btn.textContent = ""
        category3Btn.textContent = ""
        category4Btn.textContent = ""
        console.log(error)
    }
}

// itemsFetch();
loadItems();



//Grab database CAFE
const getCafe = async (cafe) => {
    const res = await fetch(baseURL + "/cafe", {
        method: "GET",
        //Tell the API the body is JSON.
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(cafe)
    })
    const data = await res.json();
    console.log(data)
    restName.textContent = `${data[0].name}`.toUpperCase();
    tagline.textContent = `${data[0].tagline}`
    address.textContent = `${data[0].address}`.toUpperCase();
    dates.textContent = `${data[0].hours}`.toUpperCase();
    phone.textContent = `${data[0].phone}`
    footerName.textContent = `${data[0].name}`.toUpperCase();
    footerInfo.textContent = `${data[0].address} · ${data[0].hours} · ${data[0].phone}`
}

getCafe();

// const cafeFetch = async () => {
//     try {
//         const res = await fetch(baseURL + "/cafe");
//         if (!res.ok) {
//             throw new Error(`Request failed: ${res.status}`);
//         }
//         const data = await res.json();
//         // console.log(data);
//         showItems(data);
//     } catch (error) {
//         status.textContent = "Couldn't load cafe. Check the console."
//         console.log(error)
//     }
// }

// cafeFetch();


//Grab database CATEGORIES
const getCategories = async (cafe) => {
    const res = await fetch(baseURL + "/category", {
        method: "GET",
        //Tell the API the body is JSON.
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(cafe)
    })
    const data = await res.json();
    console.log(data)
    category1Btn.textContent = `${data[0].name}`.toUpperCase();
    category2Btn.textContent = `${data[1].name}`.toUpperCase();
    category3Btn.textContent = `${data[2].name}`.toUpperCase();
    category4Btn.textContent = `${data[3].name}`.toUpperCase();
    category1Name.textContent = `${data[0].name}`.toUpperCase();
    category2Name.textContent = `${data[1].name}`.toUpperCase();
    category3Name.textContent = `${data[2].name}`.toUpperCase();
    category4Name.textContent = `${data[3].name}`.toUpperCase();

    category1Num.textContent = `0${data[0].id}`
    category2Num.textContent = `0${data[1].id}`
    category3Num.textContent = `0${data[2].id}`
    category4Num.textContent = `0${data[3].id}`
    console.log(data);
}

getCategories();