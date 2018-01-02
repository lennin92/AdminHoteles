@ModelType AdminHoteles.PrecioHabitacion
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>PrecioHabitacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.habitacionId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.habitacionId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioSugerido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioSugerido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioMinimo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioMinimo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.desde)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.desde)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.hasta)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hasta)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
