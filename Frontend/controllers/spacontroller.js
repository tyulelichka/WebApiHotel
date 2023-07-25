async function displaySpas() {
  let spas = await getSpa();

  let spasTable = document.getElementById("getSpa");

  for (let spa of spas) {
    const { nameSpa, priceSpa, linkSpa } = spa;

    const row = document.createElement("tr");

    const nameSpaEl = document.createElement("td");
    const priceSpaEl = document.createElement("td");
    const linkSpaEl = document.createElement("td");

    nameSpaEl.classList.add("spa-element");
    priceSpaEl.classList.add("spa-element");
    linkSpaEl.classList.add("spa-element");

    nameSpaEl.innerText = nameSpa;
    priceSpaEl.innerText = priceSpa;
    linkSpaEl.innerText = linkSpa;

    row.append(nameSpaEl, priceSpaEl, linkSpaEl);

    spasTable.append(row);
  }
}
async function getUser(id) {
  const filter = { Id: id };
  let user = await displayUser(filter);
}

async function displayViewSpas(filter) {
  let rooms = await getViewSpa(filter);
  //  console.log("rooms", rooms);
  let roomsTable = document.getElementById("getViewSpa");
  const rows = roomsTable.querySelectorAll("tr");

  // Iterate over the rows and remove them
  rows.forEach(function (row, index) {
    if (index === 0) {
      return;
    }
    row.remove();
  });
  for (let room of rooms) {
    const { id, імя, прізвище, кількістьВідвідуванняСпа } = room;

    const row = document.createElement("tr");
    row.onclick = () => getUser(id);
    const idEl = document.createElement("td");
    const імяEl = document.createElement("td");
    const прізвищеEl = document.createElement("td");
    const кількістьВідвідуванняСпаEl = document.createElement("td");
    idEl.classList.add("spaview-element");
    імяEl.classList.add("spaview-element");
    прізвищеEl.classList.add("spaview-element");
    кількістьВідвідуванняСпаEl.classList.add("spaview-element");
    idEl.innerText = id;
    імяEl.innerText = імя;
    прізвищеEl.innerText = прізвище;
    кількістьВідвідуванняСпаEl.innerText = кількістьВідвідуванняСпа;

    row.append(idEl, імяEl, прізвищеEl, кількістьВідвідуванняСпаEl);

    roomsTable.append(row);
  }
}

async function displayUser(filter) {
  let rooms = await getViewSpa(filter);
  console.log("ізф гіук", rooms);
  let roomsTable = document.getElementById("getViewSpaUser");

  const rows = roomsTable.querySelectorAll("tr");

  // Iterate over the rows and remove them
  rows.forEach(function (row, index) {
    if (index === 0) {
      return;
    }
    row.remove();
  });

  for (let room of rooms) {
    const {
      id,
      імя,
      прізвище,
      поБатькові,
      стать,
      датаНародження,
      номерТелефону,
      пошта,
      документ,
      номерБронювання,
      датаБронювання,
      назваСпа,
      ціна,
      відвідування,
      кількістьВідвідуванняСпа,
    } = room;

    const row = document.createElement("tr");

    const idEl = document.createElement("td");
    const імяEl = document.createElement("td");
    const прізвищеEl = document.createElement("td");

    const поБатьковіEl = document.createElement("td");
    const статьEl = document.createElement("td");
    const датаНародженняEl = document.createElement("td");
    const номерТелефонуEl = document.createElement("td");
    const поштаEl = document.createElement("td");
    const документEl = document.createElement("td");
    const номерБронюванняEl = document.createElement("td");
    const датаБронюванняEl = document.createElement("td");
    const назваСпаEl = document.createElement("td");
    const цінаEl = document.createElement("td");
    const відвідуванняEl = document.createElement("td");

    const кількістьВідвідуванняСпаEl = document.createElement("td");
    idEl.classList.add("spaview-element");
    імяEl.classList.add("spaview-element");
    прізвищеEl.classList.add("spaview-element");
    поБатьковіEl.classList.add("spaview-element");
    статьEl.classList.add("spaview-element");
    датаНародженняEl.classList.add("spaview-element");
    номерТелефонуEl.classList.add("spaview-element");
    поштаEl.classList.add("spaview-element");
    документEl.classList.add("spaview-element");
    номерБронюванняEl.classList.add("spaview-element");
    датаБронюванняEl.classList.add("spaview-element");
    назваСпаEl.classList.add("spaview-element");
    цінаEl.classList.add("spaview-element");
    відвідуванняEl.classList.add("spaview-element");
    кількістьВідвідуванняСпаEl.classList.add("spaview-element");

    idEl.innerText = id;
    імяEl.innerText = імя;
    прізвищеEl.innerText = прізвище;
    поБатьковіEl.innerText = поБатькові;
    статьEl.innerText = стать;
    датаНародженняEl.innerText = датаНародження;
    номерТелефонуEl.innerText = номерТелефону;
    поштаEl.innerText = пошта;
    документEl.innerText = документ;
    номерБронюванняEl.innerText = номерБронювання;
    датаБронюванняEl.innerText = датаБронювання;
    назваСпаEl.innerText = назваСпа;
    цінаEl.innerText = ціна;
    відвідуванняEl.innerText = відвідування;
    кількістьВідвідуванняСпаEl.innerText = кількістьВідвідуванняСпа;

    row.append(
      idEl,
      імяEl,
      прізвищеEl,
      поБатьковіEl,
      статьEl,
      датаНародженняEl,
      номерТелефонуEl,
      поштаEl,
      документEl,
      номерБронюванняEl,
      датаБронюванняEl,
      назваСпаEl,
      цінаEl,
      відвідуванняEl,
      кількістьВідвідуванняСпаEl
    );

    roomsTable.append(row);
  }
}

displaySpas();
displayUser();
displayViewSpas();
