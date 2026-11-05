"use strict";
const input = document.querySelector("#table-filter");
const rows = document.querySelectorAll("#applications-table tbody tr");
const result = document.querySelector("#filter-result");
function applyFilter(term) {
    const search = term.trim().toLowerCase();
    let visible = 0;
    rows.forEach((row) => {
        const matches = (row.textContent ?? "").toLowerCase().includes(search);
        row.hidden = !matches;
        if (matches) {
            visible += 1;
        }
    });
    if (result) {
        result.textContent = search ? `${visible} of ${rows.length} applications shown.` : "";
    }
}
input?.addEventListener("input", () => applyFilter(input.value));
