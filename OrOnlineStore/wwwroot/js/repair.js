const repairsList = document.getElementById("card");
const searchBar = document.getElementById('searchBar');
let repairsCharacters = [];
//Search Or Filter Repair
// searchBar.addEventListener('keyup', (e) => {
//const searchString = e.target.value.toLowerCase();
//    const filteredRepairs = (repairsCharacters).filter((repairs) => {
//        return repairs.repairType.toLowerCase().includes(searchString) ||
//            repairs.description.toLowerCase().includes(searchString);
//    });
//    displayRepairs(filteredRepairs);
//});
        // Display the Repairs
        const loadRepairs = async () => {
    try {
        const resp = await fetch('/UI/repairs/GetAll');
        repairsCharacters = await resp.json();
        displayRepairs(repairsCharacters);
    } catch (err) {
        console.log(err);
    }
};
const displayRepairs = (repairs) => {
    const htmlString = repairs.data.map((repair) => {
        return `     <div class="col-md-4 col-sm-6 col-xs-12">
            <div class="core-features">
                <div class="circle">
                    <img class="img-fluid" src="/content/blog/${repair.imageUrl}" alt="crib thumbnail">
                </div>
                <div style="height:230px" class="mb-3">
                    <h3>${repair.repairType}</h3>
                    <p><i class="fa fa-home"></i>${repair.location}</p>
                    <hr>
                    <span class="label label-primary">
                        We Are Open: Mon-Sat
                    </span>
                    <hr>
                    <a href="/UI/repairs/details/${repair.id}" id="more" class="btn btn-sm btn-primary more"> Details </a>
                    <p style="display:none;">${repairs.description}</p>
                </div>
            </div>
        </div>`;
    }).join('');
    repairsList.innerHTML = htmlString;
}
loadRepairs();