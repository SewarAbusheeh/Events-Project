//// object to store a data
//var car = {
//    "name": "saphera",
//    "model": "honda"
//}
//// featch data from object 
//document.write("<h1>" + car.name + "</h1>")

//// list or  array 
//var cars = ["Honda", "Merceds"]

//// Featch Data 
//document.write("<h1>" + cars[0] + "</h1>")

////Combine object and Array 

//var Cars1 = [

//    {
//        "name": "saphera",
//        "Model": "honda"
//    },
//    {
//        "name": "MASSI",
//        "Model": "Merceds"
//    }

//]
//// Cars1 called JSON but in js file so IF I delete the var Cars1 its not understand for the browser so i will take it to ther file Cars1,json


/*by this <script src="script.js"></script>  we featch the data from js to print*/
// Now  I wi;; featch the data form JSON 

// these Data are fetch from JSON File 
//XMLHttpRequest(); // TO FETCH DATA IN XML  
// AJAX 
var xReq = new XMLHttpRequest();   // take to function 1 open 2 send 
xReq.open('GET', 'Cres1.json'); // Now i open the connection   ('to fetch data -->get ,to seend Data -->post ' ,'مسار الاتصال')
xReq.onload = function () {  //  onload :func to fetch Data what i want to do with tis Data 
    var xData = xReq.responseText;
    document.write(xReq.responseText);    //responseText : this proprty will the text
    document.write(xData[0]);  // this will print a [ just , i  way find a way to convert the text inside response Text to read as DataBase  by
    // JSON.parse  
    var xData = JSON.parse(xReq.responseText); //[OBJECT object ] browser understand that 2 object is exist 
    document.write(xData[0].name);
    document.write(xData[0].model);
    document.write(xData[1].name);
    document.write(xData[1].model);
};
xReq.send(); // to send the data to Browser 