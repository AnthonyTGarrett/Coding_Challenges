// Remove words from the sentence if they contain exactly one exclamation mark. Words are separated by a single space, without leading/trailing spaces.
// Examples

// remove("Hi!") === ""
// remove("Hi! Hi!") === ""
// remove("Hi! Hi! Hi!") === ""
// remove("Hi Hi! Hi!") === "Hi"
// remove("Hi! !Hi Hi!") === ""
// remove("Hi! Hi!! Hi!") === "Hi!!"
// remove("Hi! !Hi! Hi!") === "!Hi!"
function remove(string) {
  let words = string.split(" ");
  let result = [];
  counter = 0;

  words.forEach((el) => {
    for (let c of el) {
      if (c == "!") counter++;
    }
    if (counter != 1) {
      result.push(el);
    }
    counter = 0;
  });
  return result.join(" ");
}
