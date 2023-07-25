let prev = document.getElementById("btn-prev"),
  next = document.getElementById("btn-next"),
  slides = document.querySelectorAll(".slide"),
  dots = document.querySelectorAll(".dot");

let index = 0;
const activeSlide = (n) => {
  for (slide of slides) {
    slide.classList.remove("active");
  }
  slides[n].classList.add("active");
};
const activeDot = (n) => {
  for (dot of dots) {
    dot.classList.remove("active");
  }
  dots[n].classList.add("active");
};
const prepareCurruntSlide = (ind) => {
  activeSlide(index);
  activeDot(index);
};

const nextSlide = () => {
  if (index == slides.length - 1) {
    index = 0;
    prepareCurruntSlide(index);
  } else {
    index++;
    prepareCurruntSlide(index);
  }
};

const prevSlide = () => {
  if (index == 0) {
    index = slides.length - 1;
    prepareCurruntSlide(index);
  } else {
    index--;
    prepareCurruntSlide(index);
  }
};

dots.forEach((item, indexDot) => {
  item.addEventListener("click", () => {
    index = indexDot;
    prepareCurruntSlide(index);
  });
});

let timerId = setInterval(nextSlide, 2000);

const stopAutoSlide = () => {
  clearInterval(timerId);
};
next.addEventListener(
  "click",
  (slideAutoStop = () => {
    nextSlide(true);
  })
);

next.addEventListener("click", nextSlide);
prev.addEventListener("click", prevSlide);

var slider = document.getElementById("myRange");
var output = document.getElementById("demo");
output.innerHTML = slider.value; // Display the default slider value

// Update the current slider value (each time you drag the slider handle)
slider.oninput = function () {
  output.innerHTML = this.value;
};
