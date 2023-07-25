async function displayApartamets() {
  let rooms = await getApartament();

  let roomsTable = document.getElementById("getRoom");

  for (let room of rooms) {
    const { nameCategori, priceCategori, linkApartament } = room;

    const row = document.createElement("tr");

    const nameCategoriEl = document.createElement("td");
    const priceCategoriEl = document.createElement("td");
    const linkApartamentEl = document.createElement("td");

    nameCategoriEl.classList.add("room-element");
    priceCategoriEl.classList.add("room-element");
    linkApartamentEl.classList.add("room-element");

    nameCategoriEl.innerText = nameCategori;
    priceCategoriEl.innerText = priceCategori;
    linkApartamentEl.innerText = linkApartament;

    row.append(nameCategoriEl, priceCategoriEl, linkApartamentEl);

    roomsTable.append(row);
  }
}

async function getUser(id) {
  const filter = { Id: id };
  let user = await displayUser(filter);
}

async function displayViewApartamets(filter) {
  let rooms = await getViewApartament(filter);
  //  console.log("rooms", rooms);
  let roomsTable = document.getElementById("getViewApartament");
  const rows = roomsTable.querySelectorAll("tr");

  // Iterate over the rows and remove them
  rows.forEach(function (row, index) {
    if (index === 0) {
      return;
    }
    row.remove();
  });
  for (let room of rooms) {
    const { id, імя, прізвище, кількістьРазівВідпочинку } = room;

    const row = document.createElement("tr");
    row.onclick = () => getUser(id);
    const idEl = document.createElement("td");
    const імяEl = document.createElement("td");
    const прізвищеEl = document.createElement("td");
    const кількістьРазівВідпочинкуEl = document.createElement("td");
    idEl.classList.add("apartamentview-element");
    імяEl.classList.add("apartamentview-element");
    прізвищеEl.classList.add("apartamentview-element");
    кількістьРазівВідпочинкуEl.classList.add("apartamentview-element");
    idEl.innerText = id;
    імяEl.innerText = імя;
    прізвищеEl.innerText = прізвище;
    кількістьРазівВідпочинкуEl.innerText = кількістьРазівВідпочинку;

    row.append(idEl, імяEl, прізвищеEl, кількістьРазівВідпочинкуEl);

    roomsTable.append(row);
  }
}

async function displayUser(filter) {
  let rooms = await getViewApartament(filter);

  let roomsTable = document.getElementById("getViewApartamentUser");
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

      ціна,
      датаБронювання,
      категоріяАпартаментів,
      заселився,
      виселення,
      кількістьРазівВідпочинку,
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

    const цінаEl = document.createElement("td");
    const датаБронюванняEl = document.createElement("td");
    const категоріяАпартаментівEl = document.createElement("td");
    const заселивсяEl = document.createElement("td");
    const виселенняEl = document.createElement("td");
    const кількістьРазівВідпочинкуEl = document.createElement("td");

    idEl.classList.add("apartamentview-element");
    імяEl.classList.add("apartamentview-element");
    прізвищеEl.classList.add("apartamentview-element");
    поБатьковіEl.classList.add("apartamentview-element");
    статьEl.classList.add("apartamentview-element");
    датаНародженняEl.classList.add("apartamentview-element");
    номерТелефонуEl.classList.add("apartamentview-element");
    поштаEl.classList.add("apartamentview-element");
    документEl.classList.add("apartamentview-element");
    номерБронюванняEl.classList.add("apartamentview-element");
    цінаEl.classList.add("apartamentview-element");
    датаБронюванняEl.classList.add("apartamentview-element");

    категоріяАпартаментівEl.classList.add("apartamentview-element");
    заселивсяEl.classList.add("apartamentview-element");
    виселенняEl.classList.add("apartamentview-element");
    кількістьРазівВідпочинкуEl.classList.add("apartamentview-element");
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

    цінаEl.innerText = ціна;
    датаБронюванняEl.innerText = датаБронювання;
    категоріяАпартаментівEl.innerText = категоріяАпартаментів;
    заселивсяEl.innerText = заселився;
    виселенняEl.innerText = виселення;
    кількістьРазівВідпочинкуEl.innerText = кількістьРазівВідпочинку;
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

      цінаEl,
      датаБронюванняEl,
      категоріяАпартаментівEl,
      заселивсяEl,
      виселенняEl,
      кількістьРазівВідпочинкуEl
    );

    roomsTable.append(row);
  }
}

displayApartamets();
displayUser();
displayViewApartamets();
