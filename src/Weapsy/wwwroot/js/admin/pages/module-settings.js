var inheritPermissions = $("#InheritPermissions");
var formGroupRoleGrid = $("#form-group-role-grid");
//document.getElementById("InheritPermissions").checked = false;
$(formGroupRoleGrid).hide();

$(inheritPermissions).bind("click", function () {
    if ($(inheritPermissions).is(":checked")) {
        $(formGroupRoleGrid).slideUp(500);
    }
    else {
        $(formGroupRoleGrid).slideDown(500);
    }
});