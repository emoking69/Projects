let current = 50;
let left = 0;
let right = 100;
let found = false;


function Correct() {
  alert("Yay! I guessed your number!");
  found = true;
}

function Lower() {
  if(found != true){  
  right = current;
  current = (left + current) / 2;
  document.getElementById("num").textContent = Math.trunc(current);   
  }
}

function Higher() {
  if(found != true){  
  left = current;
  current = (current + right) / 2;
  document.getElementById("num").textContent = Math.trunc(current);    
  }
}

function Restart() {
    current = 50;
    left = 0;
    right = 100;
    found = false;
    document.getElementById("num").textContent = current; 
}