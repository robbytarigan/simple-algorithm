function formatDate(userDate) {
  // format from M/D/YYYY to YYYYMMDD
  const dateParts = userDate.split('/');

  return [dateParts[2], dateParts[0].padStart(2, '0'), dateParts[1].padStart(2, '0') ].join('');
}

const date = { formatDate: formatDate };

module.exports = date;