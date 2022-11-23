//Function to add a section of work experience item.
const button = document.getElementById("addworkExp")
const el = document.getElementById("workExp_parent")
var sections = 1;
function addWorkExp(sections) {
    const html = `<div class="row" id="workExp_${sections}">
        <div class="col-md-12">
            <div asp-validation-summary="ModelOnly" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="Title" class="control-label"></label>
                <input asp-for="Title" class="form-control" />
                <span asp-validation-for="Title" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="Description" class="control-label"></label>
                <input asp-for="Description" class="form-control" />
                <span asp-validation-for="Description" class="text-danger"></span>
            </div>
            <div class="form-group col-md-4">
                <label asp-for="StartDate" class="control-label"></label>
                <input asp-for="StartDate" class="form-control" />
                <span asp-validation-for="StartDate" class="text-danger"></span>
            </div>
            <div class="form-group col-md-4">
                <label asp-for="EndDate" class="control-label"></label>
                <input asp-for="EndDate" class="form-control" />
                <span asp-validation-for="EndDate" class="text-danger"></span>
            </div>
            <div class="form-group">
                <input type="submit" value="Save" class="btn btn-primary" />
            </div>
        </div>
    </div>`
    return html
}

button.addEventListener("click", () => {
    sections += 1;
    const div = addWorkExp(sections)
    el.insertAdjacentHTML("beforeend",div)
})    
