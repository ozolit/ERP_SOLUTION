function pageLoad() {
    alert("PersonType");
    addHandler(get("btnSubmitPersonType"), "click", createPersonType);
    

}

function createPersonType() {
    try {
        var parentDiv = get("personTypeParent");
        alert(parentDiv);
        var txtPersonType = get("personType", parentDiv);
        alert(txtPersonType);
        var personType = checkInput(txtPersonType, "Enter Person type here");

        var personTypeObject = {Name: personType };
        alert(JSON.stringify(personTypeObject));

        JqueryAjaxServiceCall(JSON.stringify(personTypeObject), "CreatePersonType", "../../Common/Common", function (personTypeId) {
            if (personTypeId > 0) {
                personTypeObject.Id = personTypeId;
                alert("Data Succesfully Inserted");
                txtPersonType.value = "";
            }
            else if (personTypeId == -1) {
                alert("server Could not be reached")
            } else if (personTypeId == -2) {
            alert("Data Already Exists");
            } else {
            alert("Error While Processing te data");
           }
        });

    } catch (e) {
        alert(e.message);
    }
}