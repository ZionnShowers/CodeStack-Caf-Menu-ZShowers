const baseURL = "http://localhost:5292/api"

export const itemsFetch = async () => {
    const res = await fetch(baseURL + "/item");
    if (!res.ok) {
        throw new Error(`Request failed: ${res.status}`);
    }
    const data = await res.json();
    return data;
}