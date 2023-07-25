window.onload = function () {
    // Obtener referencias a los elementos del DOM
    const selectUser = document.getElementById('selectUser');
    const vehicleList = document.getElementById('vehicleList');
    
    const apiUrl = document.getElementById("apiUrl1Data").getAttribute("data-api-url");
    const apiUrlWithEndpoint = apiUrl + "/api/Vehicle/user/";

    let isFirstExecution = true;

    // Función para actualizar la información del usuario en la página
    async function updateUserInfo(userId) {
        if (userId) {
            showUserData(userId);
            showVehicleContainer();

            try {
                const response = await fetch(`${apiUrlWithEndpoint}${userId}`);
                if (response.ok) {
                    const vehicles = await response.json();
                    // Aquí puedes mostrar los vehículos en la lista "vehicleList"
                    showVehicles(vehicles);
                    showfile(vehicles)
                } else {
                    console.log('Error al obtener los vehículos del usuario');
                }
            } catch (error) {
                console.error('Error al realizar la llamada a la API:', error);
            }
        } else {
            // Si no hay un usuario seleccionado, limpiar los campos de información
            hideUserData();
            hideVehicleContainer();
        }
    }

    // Mostrar los datos del primer usuario al cargar la página
    if (isFirstExecution === true) {
        updateUserInfo(selectUser.value);
        isFirstExecution = false;
    }

    selectUser.addEventListener('change', function () {
        const selectedUserId = selectUser.value;
        updateUserInfo(selectedUserId);
    });

    //Funciones ocultar
    function hideUserData() {
        document.querySelectorAll('p').forEach(elemento => elemento.classList.add('ocultar-bloque-usuario'));
        document.getElementById('nombre').style.display = 'none';
        document.getElementById('apellidos').style.display = 'none';
        document.getElementById('dni').style.display = 'none';
        document.getElementById('carnet').style.display = 'none';
        document.getElementById('telefono').style.display = 'none';
        document.getElementById('mensajeNoUsuarioSeleccionado').style.display = 'block';
    }

    function hideVehicleContainer() {
        const vehicleContainer = document.getElementById('vehicleContainer');
        vehicleContainer.style.display = 'none';
    }

    //Funciones mostrar
    function showUserData(userId) {
        document.querySelectorAll('.ocultar-bloque-usuario').forEach(elemento => elemento.classList.remove('ocultar-bloque-usuario'));
        document.getElementById('nombre').style.display = 'inline';
        document.getElementById('apellidos').style.display = 'inline';
        document.getElementById('dni').style.display = 'inline';
        document.getElementById('carnet').style.display = 'inline';
        document.getElementById('telefono').style.display = 'inline';
        document.getElementById('mensajeNoUsuarioSeleccionado').style.display = 'none';

        const selectedUser = users.find(user => user.id === parseInt(userId));
        document.getElementById('nombre').innerText = selectedUser.nombre;
        document.getElementById('apellidos').innerText = selectedUser.apellidos;
        document.getElementById('dni').innerText = selectedUser.dni;
        document.getElementById('carnet').innerText = selectedUser.carnet;
        document.getElementById('telefono').innerText = selectedUser.telefono;
    };
    function showVehicles(vehicles) {
        // Obtener la referencia al cuerpo de la tabla
        const vehicleTableBody = document.getElementById('vehicleTable').querySelector('tbody');

        // Limpiar la tabla antes de mostrar los vehículos
        vehicleTableBody.innerHTML = '';

        // Crear una fila en la tabla para cada vehículo
        vehicles.forEach(vehicle => {
            const row = document.createElement('tr');

            // Crear y agregar celdas de datos para cada columna
            const marcaCell = document.createElement('td');
            marcaCell.textContent = vehicle.marca;
            row.appendChild(marcaCell);

            const modeloCell = document.createElement('td');
            modeloCell.textContent = vehicle.modelo;
            row.appendChild(modeloCell);

            const potenciaCell = document.createElement('td');
            potenciaCell.textContent = vehicle.potencia;
            row.appendChild(potenciaCell);

            const categoriaCell = document.createElement('td');
            categoriaCell.textContent = vehicle.categoria;
            row.appendChild(categoriaCell);

            // Agregar la fila a la tabla
            vehicleTableBody.appendChild(row);
        });
    }
    function showVehicleContainer() {
        const vehicleContainer = document.getElementById('vehicleContainer');
        vehicleContainer.style.display = 'block';
    }
};