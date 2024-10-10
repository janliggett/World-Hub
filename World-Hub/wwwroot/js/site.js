// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//https://developer.mozilla.org/en-US/docs/Web/API/Document/createElement
//https://developer.mozilla.org/en-US/docs/Web/API/Node/cloneNode

function Duplicate() {
    const test = document.getElementById("testEle");
    //const clone = test.cloneNode(true);

    const worlds = document.getElementById("worlds");
    const universe = worlds.children;
    console.log(universe);

    document.body.insertBefore(test, worlds);  
}