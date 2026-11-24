const baseURL = "http://localhost:5292/api"

export const itemsFetch = async () => {
    const res = await fetch(baseURL + "/item");
    if (!res.ok) {
        throw new Error(`Request failed: ${res.status}`);
    }
    const data = await res.json();
    return data;
}

export const cafeFetch = async (cafe) => {
    const res = await fetch(baseURL + "/cafe", {
        method: "GET",
        //Tell the API the body is JSON.
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(cafe)
    })
    const data = await res.json();
    return data;
}

export const categoriesFetch = async (cafe) => {
    const res = await fetch(baseURL + "/category", {
        method: "GET",
        //Tell the API the body is JSON.
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(cafe)
    })
    const data = await res.json();
    return data;
}