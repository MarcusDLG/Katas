function capitalize(s) {
  let rv2 = "";
  let rv = "";
  for (let i = 0; i < s.length; i++) {
    if (i % 2 === 0) {
      rv += s[i].toUpperCase();
      rv2 += s[i].toLowerCase();
    } else {
      rv += s[i].toLowerCase();
      rv2 += s[i].toUpperCase();
    }
  }
  return [rv, rv2];
}
