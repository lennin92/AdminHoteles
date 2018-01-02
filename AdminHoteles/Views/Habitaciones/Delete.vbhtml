@ModelType AdminHoteles.Habitacion
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Habitacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.hotelId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hotelId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipoHabitacionId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipoHabitacionId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nombreHabitacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombreHabitacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.descripcionHabitacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.descripcionHabitacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ubicacionHabitacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ubicacionHabitacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioBaseHabitacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioBaseHabitacion)
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
