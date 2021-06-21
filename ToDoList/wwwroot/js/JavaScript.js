const list = document.querySelector('ul');  //get the list on my ul tag
const clearBtn = document.getElementById('clear');//get clear button 
list.addEventListener('click', function(list) {//list items

  if( list.target.tagName === 'LI') {
    if(list.target.getAttribute("class") == 'done')
      list.target.removeAttribute("class");
    else
      list.target.setAttribute("class",'done'); 
  }
}, false);
//function
function displayListItem(i) {
    const n = document.createElement("li");
    //console.log(i);
    document.getElementById("todo").appendChild(n);
    n.innerHTML = i;    
}
function checkEnter(e) {
    e = e || event;
    const t = /textarea/i.test((e.target || e.srcElement).tagName);
    return t || (e.keyCode || e.which || e.charCode || 0) !== 13
}
function send(event) {
  const e=document.getElementById("list-input").value;//lets send listinput to display 
  document.getElementById("list-input").value = "";
  if(e.trim().length > 0 && e){
    displayListItem(e);
  }
 event.preventDefault();
};
document.querySelector("form").onkeypress = checkEnter;
document.querySelector("form").addEventListener('submit', send, true);
const today = new Date();//date
document.getElementById("date").innerHTML = today;//date and time, credit to https://www.w3schools.com/js/js_date_methods_set.asp 
const closebtns = document.getElementsByClassName("close");//clear all from the li input
clearBtn.addEventListener("click", () => {//clear
localStorage.removeItem('list', list.innerHTML = '');//remove all
listItem.appendChild(listText);
listText.textContent = myItem;
listItem.appendChild(listBtn);
listBtn.textContent = 'Delete';
list.appendChild(listItem);
    listBtn.onclick = function(e) {
      list.removeChild(listItem);
    }

    input.focus();
  }
)

	