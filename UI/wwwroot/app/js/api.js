function GetSmileDetails() {
  var datas = {
    smiles: "OCCc1ccn2cnccc12",
    path: "",
    cid: "",
  };
  console.log(JSON.stringify(datas));
  $.ajax({
    type: "POST",
    url: "http://localhost:5212/details",
    data: JSON.stringify(datas),
    contentType: "application/json; charset=utf-8",
    dataType: "json",
    success: function (response) {
      alert(response[0]);
    },
    error: function (error) {
      alert("Error during saving!");
    },
  });
}
