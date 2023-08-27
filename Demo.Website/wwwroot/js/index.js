/// <reference types="jquery"/>
/// <reference types="datatables.net"/>
async function deleteUser(id) {
	const res = await fetch(`/api/Users/${id}`, {
		method: "DELETE"
	});

	if (res.ok) {
		location.reload();
	} else {
		alert("Failed to delete user");
	}
}

/**
 * 
 * @param {HTMLElement} parent
 * @param {string} href
 * @param {string} text
 */
function addLink(parent, href, text) {
	const a = document.createElement("a");
	a.className = "btn btn-outline-primary";
	a.href = href;
	a.innerText = text;
	parent.appendChild(a);
}

var dt = $("#table").DataTable({
	searching: false,
	columns: [
		{
		},
		{
		},
		{
		},
		{
		},
		{
		},
		{
			searchable: false,
			orderable: false
		},
	],
	dom: '<"top d-flex gap-1 pb-1"l<"flex-fill">fr>t<"bottom"ip>'
});

$("#table_wrapper .top").each((i, e) => {
	addLink(e, "/Edit", "Add User");
	addLink(e, "/api/Users/csv", "Download");
});
