@ModelType AdminHoteles.ReservacionHabitacion
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ReservacionHabitacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.habitacionId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.habitacionId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.clienteId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.clienteId)
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

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioAcordado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioAcordado)
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
