async function getApartament() {
  const response = await fetch("https://localhost:7127/api/Apartament", {
    method: "GET",
  });
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}

async function getViewApartament(filter) {
  const response = await fetch(
    "https://localhost:7127/api/ViewApartament/getActive?" +
      new URLSearchParams(filter),
    {
      method: "GET",
    }
  );
  const resulf = await response.json();
  console.log(resulf);
  return resulf;
}

function setupCheckboxHandlers() {
  const checkboxes = document.querySelectorAll("input[type='checkbox']");
  checkboxes.forEach((cb) => {
    cb.onchange = checkboxOnchange;
  });
}

function checkboxOnchange(event) {
  const filterName = event.target.name;
  const checboxId = event.target.id;

  const checkboxes = document.querySelectorAll(
    `input[type='checkbox'][name='${filterName}']`
  );
  checkboxes.forEach((cb) => {
    if (cb.id !== checboxId) {
      cb.checked = false;
    }
  });
}

function setupFormSubmit() {
  const form = document.querySelector("#filter");
  form.onsubmit = async function (event) {
    event.preventDefault();
    const formData = new FormData(event.target);
    const filter = Object.fromEntries(formData);

    const result = await getViewApartament(filter);
    displayViewApartamets(filter);
    console.log(filter, result);
  };
}

setupCheckboxHandlers();
setupFormSubmit();
