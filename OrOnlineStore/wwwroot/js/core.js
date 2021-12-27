var areas = [
    {
        "id": 1,
        "city": "Orlando",
    },
    {
        "id": 2,
        "city": "Dundee",
    },
    {
        "id": 3,
        "city": "Haines City",
    },
    {
        "id": 4,
        "city": "Winter Park",
    },
    {
        "id": 5,
        "city": "Orlo Vista",
    },
    {
        "id": 6,
        "city": "Pine Hills",
    },
    {
        "id": 7,
        "city": "Maitland",
    },
    {
        "id": 8,
        "city": "Apopka",
    },
    {
        "id": 9,
        "city": "Ocoee",
    },
    {
        "id": 10,
        "city": "Sanford",
    },
    {
        "id": 11,
        "city": "Longwood",
    },
    {
        "id": 12,
        "city": "Windermere",
    },
    {
        "id": 13,
        "city": "Winter Garden",
    },
    {
        "id": 14,
        "city": "Lake Buena Vista",
    },
    {
        "id": 15,
        "city": "Lake Mary",
    },
    {
        "id": 16,
        "city": "Winter Springs",
    },
    {
        "id": 17,
        "city": "Kissimmee",
    },
    {
        "id": 18,
        "city": "Casselberry",
    },
    {
        "id": 19,
        "city": "Celebration",
    },
    {
        "id": 20,
        "city": "Davenport",
    },
    {
        "id": 21,
        "city": "Clermont",
    },
    {
        "id": 22,
        "city": "Reunion",
    },
    {
        "id": 23,
        "city": "Lakeland",
    }

];

var repairs = [
    {
        "id": 1,
        "type": "Cooktops Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "cooktop"
    },
    {
        "id": 2,
        "type": "Garbage Disposal Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "garbage-disposal"
    },
    {
        "id": 3,
        "type": "Range / Stoves Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "stove"
    },
    {
        "id": 4,
        "type": "Refrigator Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "refrigator"
    },
    {
        "id": 5,
        "type": "Stand Alone Freezers Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "alonefreezer"
    },
    {
        "id": 6,
        "type": "Wall Oven Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "wall-oven"
    },
    {
        "id": 7,
        "type": "Washer and Dryer Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "washer-dryer"
    },
    {
        "id": 8,
        "type": "Dish Washer Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "dishwasher"
    },
    {
        "id": 9,
        "type": "Ice Machine Repair",
        "price": 0,
        "address": "Residential Repairs",
        "description": "We are committed to providing the friendliest, most reliable, same-day service ",
        "days": "Mon-Fri",
        "area": "orlando",
        "image": "ice-maker"
    }
];

/* var card = document.getElementById("card");
 for (var i = 0; i < repairs.length; i++) {
     var repair = repairs[i];
     card.innerHTML +=`
            <div class="col-md-4 col-sm-6 col-xs-12">
                                      <div class="core-features">
                                             <div class="circle">
                                                 <img class="img-fluid" src="/content/images/repairs/${repair.image}.jpg" alt="crib thumbnail">
                                             </div>
                                             <div style="height:230px" class="mb-3">
                                                 <h3>${repair.type}</h3>
                                                 <span class="label label-primary">
                                                       Areas: ${repair.area}
                                                 </span>
                                                 <p><i class="fa fa-home"></i>${repair.address}</p>
                                                     <hr>
                                                 <span class="label label-primary">
                                                     Days: ${repair.days}
                                                  </span>
                                                 <hr>
                                                 <button id="more" class="btn btn-sm btn-primary more"> Details </button>
                                                 <p style="display:none;">${repair.description}</p>
                                             </div>
                                       </div>
                                   </div>
         `;
 }
 var more = document.getElementsByClassName("more")
 for (var i = 0; i < more.length; i++) {
     more[i].onclick = function () {
         this.classList.toggle("active");
         var panel = this.nextElementSibling;
         if (panel.style.display === 'block') {
             panel.style.display = 'none';
         } else {
             panel.style.display = 'block';
         }
     }
 }*/


var city = document.getElementById("city");
for (var i = 0; i < areas.length; i++) {
    var area = areas[i];
    city.innerHTML += `
                <ul class="city-circle">
                     <li class="badge badge-primary"><i class="fa fa-map-marker"></i> ${area.city}</li>
               </ul >`;
}