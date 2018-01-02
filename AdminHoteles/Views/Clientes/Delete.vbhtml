@ModelType AdminHoteles.Cliente
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Cliente</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombresCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombresCliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.apellidosCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.apellidosCliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.numeroIdentificacionCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.numeroIdentificacionCliente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipoIdentificacionCliente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipoIdentificacionCliente)
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
