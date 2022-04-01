function pageLoad() {
    alert("Welcome to School");
    addHandler(get("btnSubmitSchoolType"), "click", createSchoolType);
}

function createSchoolType() {
    try {
        var parentDiv = get("SchoolTypeParent");
        alert(parentDiv);
        var txtSchoolType = get("schoolType", parentDiv);
        alert(txtSchoolType);
        var schoolType = checkInput(txtSchoolType, "Enter School type here");

        var schoolTypeObject = { Name: schoolType };

        JqueryAjaxServiceCall(JSON.stringify(schoolTypeObject), "CreateSchoolType", "../../Common/Common", function (SchoolTypeId) {
            if (SchoolTypeId > 0) {
                //schoolTypeObject.Id = SchoolTypeId;
                alert("Data Succesfully Inserted");
                txtSchoolType.value = "";
            
            } else if (SchoolTypeId == -2) {
                alert("Data Already Exists");

            }else if (SchoolTypeId == -1) {
                alert("server Could not be reached")
            
            } else {
                alert("Error While Processing te data");
            }
        });

    } catch (e) {
        alert(e.message);
    }
}