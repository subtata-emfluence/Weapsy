var inheritPermissions = $("#InheritPermissions");
var formGroupRoleGrid = $("#form-group-role-grid");
/* Role-grid stays hidden at page-load*/
$(formGroupRoleGrid).hide();

$(inheritPermissions).bind("click", function () {
    if ($(inheritPermissions).is(":checked")) {
        $(formGroupRoleGrid).slideUp(500);
    }
    else {
        $(formGroupRoleGrid).slideDown(500);
    }
});