/**
 * Write a function that converts user entered date formatted as M/D/YYYY to a format required by an API (YYYYMMDD). The parameter "userDate" and the return value are strings.
 * For example, it should convert user entered date "12/31/2014" to "20141231" suitable for the API.
 */

function formatDate(userDate) {
  // format from M/D/YYYY to YYYYMMDD
  const dateParts = userDate.split('/');

  return [dateParts[2], dateParts[0].padStart(2, '0'), dateParts[1].padStart(2, '0') ].join('');
}

const date = { formatDate: formatDate };

module.exports = date;