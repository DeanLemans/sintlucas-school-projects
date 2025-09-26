

const change = document.getElementById("imgTUK");
const abtme = document.getElementById("abtme");
const myproj = document.getElementById("myproj");
const myexp = document.getElementById("myexp");
const mrinfo1 = document.getElementById("frggr");
const mrinfo2 = document.getElementById("pc");
const PBMT = document.getElementById("PBMT");
const PBT = document.getElementById("PBT");
const boutme = document.getElementById("bm");
const R1E1 = document.getElementById("R1E1");
const R1E2 = document.getElementById("R1E2");
const R2E1 = document.getElementById("R2E1");
const R2E2 = document.getElementById("R2E2");
const R3E1 = document.getElementById("R3E1");
const lng = "L";

if (document.URL.includes("index")) {

    if (localStorage.getItem(lng) === "Brit") {
        change.setAttribute("id", "imgTUK");
        change.src = "IMG/translateNL.png";
        abtme.textContent = "About Me";
        myproj.textContent = "My Projects";
        myexp.textContent = "Experience";
    } else if (localStorage.getItem(lng) === "NL") {
        change.setAttribute("id", "imgTNL");
        change.src = "IMG/translateUK.png";
        abtme.textContent = "Over Mij";
        myproj.textContent = "Mijn Projecten";
        myexp.textContent = "Ervaring";
    }
} else if (document.URL.includes("Proj")) {
    if (localStorage.getItem(lng) === "Brit") {
        abtme.textContent = "About Me";
        myexp.textContent = "Experience";
        mrinfo1.textContent = "More Info";
        mrinfo2.textContent = "More Info";
        PBMT.textContent = "This is my personal favorite project so far.";
        PBT.textContent = "It is a website about designing your own train. I like it mostly because i learnt a lot working on it";
    }
    else if (localStorage.getItem(lng) === "NL") {
        abtme.textContent = "Over Mij";
        myexp.textContent = "Ervaring";
        mrinfo1.textContent = "Meer Info";
        mrinfo2.textContent = "Meer Info";
        PBMT.textContent = "Dit is mijn favoriete project tot nu toe.";
        PBT.textContent = "Het is een website over je eigen trein designen. Ik vind het vooral de leukste omdat ik er veel van heb geleerd";
    }
} else if (document.URL.includes("About")) {

    if (localStorage.getItem(lng) === "Brit") {
        myproj.textContent = "My Projects";
        myexp.textContent = "Experience";
        boutme.textContent = "I'm a 17-year-old web development student currently in my second year of study. Although I’m focused on learning the technical aspects, I'm also interested in developing my design skills, as I’m not yet very good in that area. I’m working to improve because I know that good design can make a huge difference in web development. I generally work better alone, as I’m a quieter person and tend to focus more effectively without too many distractions. I enjoy diving deep into tasks and exploring ideas on my own, which helps me understand concepts more thoroughly. My goal is to become a well-rounded web developer who can balance both technical and design aspects to create engaging websites.";
    }
    else if (localStorage.getItem(lng) === "NL") {
        myproj.textContent = "Mijn Projecten";
        myexp.textContent = "Experience";
        boutme.textContent = "ik ben een 17 jarige web devolopment student en zit momenteel in mijn 2de jaar van de study. Hoewel ik focus om het devolopen gedeelte, ben ik ook geintreseerd om mijn design te verbeteren, omdat ik daar momenteel nog niet heel goed in ben. Ik doe dit omdat ik weet dat design een groot verschil kan maken in web devolopment. In het algemeen werk ik alleen beter, omdat ik een stiller persoon ben ik beter kan focussen zonder teveel afleiding. Ik vindt het leuk om iddeen op mezelf te vinden en ook zelf problemen op te lossen. Mijn doel is om een developer te worden die goed is allen onderdelen van het vak waardoor ik het beste kan maken.";
    }
} else if (document.URL.includes("Expirience")) {

    if (localStorage.getItem(lng) === "Brit") {
        myproj.textContent = "My Projects";
        myexp.textContent = "Experience";
        R1E1.textContent = "Study: I am a student at SintLucas eindhoven";
        R1E2.textContent = "Im trying to improve my design because its currently pretty bad in my own opinion.";
        R2E1.textContent = "I know the basics and a bit more of css and html, i learned this in the first (and a bit in the second) year of the study.";
        R2E2.textContent = "And it all leads up to this website where i tried to use all of my skills learned so far.";
        R3E1.textContent = "I know the basics of javascript it might not be optimal but all of it works.";
    }
    else if (localStorage.getItem(lng) === "NL") {
        myproj.textContent = "Mijn Projecten";
        abtme.textContent = "Over Mij";
        R1E1.textContent = "Studie: Ik ben een student op SintLucas eindhoven";
        R1E2.textContent = "Ik probeer mijn design talenten te verbeteren want naar mijn mening zijn ze momenteel niet goed.";
        R2E1.textContent = "Ik ken de basics en iets meer van css en html, ik heb dit geleerd in het eerste (en een beetje het tweede) jaar van de studie.";
        R2E2.textContent = "Alles heeft uiteindelijk geleid naar deze website waar ik zoveel mogelijk van mijn talenten probeer te laten zien.";
        R3E1.textContent = "Ik ken de basics van javascript het is willicht niet optimaal maar alles werkt zoals bedoelt.";
    }
}
else{}

if (document.URL.includes("index")){
    change.addEventListener("click", function (e) {
        if (e.target.id === "imgTUK") {
            abtme.textContent = "Over Mij";
            myproj.textContent = "Mijn Projecten";
            myexp.textContent = "Ervaring";
            change.src = "IMG/translateUK.png";
            change.setAttribute("id", "imgTNL");
            localStorage.setItem(lng, "NL");
        }
        else if (e.target.id === "imgTNL") {
            abtme.textContent = "About Me";
            myproj.textContent = "My Projects";
            myexp.textContent = "Experience";
            change.src = "IMG/translateNL.png";
            change.setAttribute("id", "imgTUK");
            localStorage.setItem(lng, "Brit");
        }
    });
}
else if(document.URL.includes("Proj")){
    var modal = document.getElementById("myModal");
    var pc = document.getElementById("pc");
    var frggr = document.getElementById("frggr");
    var span = document.getElementsByClassName("close")[0];
    var img = document.getElementById("webimg");
    var mtxt = document.getElementById("webname");
    var stxt = document.getElementById("webtxt");

    pc.onclick = function() {
        if (localStorage.getItem(lng) === "Brit") {
            mtxt.textContent = "Point & Click";
            stxt.textContent = "It was the first project that heavely relied on javascript so that was fun.";
            img.src = "IMG/P%25C.png";
            modal.style.display = "block";
        }
        else if (localStorage.getItem(lng) === "NL"){
            mtxt.textContent = "Point & Click";
            stxt.textContent = "Het was het eerste project wat veel gerbuik maakte van javascript en dat vond ik wel leuk";
            img.src = "IMG/P%25C.png";
            modal.style.display = "block";
        }
    }

    frggr.onclick = function() {
        if (localStorage.getItem(lng) === "Brit"){
            mtxt.textContent = "Frogger";
            stxt.textContent = "It was made using only AI one partner and 0 code written by humans.";
            img.src = "IMG/FROGGER.png";
            modal.style.display = "block";}
        else if(localStorage.getItem(lng) === "NL"){
            mtxt.textContent = "Frogger";
            stxt.textContent = "De game was gemaakt met gebruik van AI, 1 teamgenoot en 0 code geschreven door echte mensen";
            img.src = "IMG/FROGGER.png";
            modal.style.display = "block";
        }
    }

    span.onclick = function() {
        modal.style.display = "none";
    }

    window.onclick = function(event) {
        if (event.target === modal) {
            modal.style.display = "none";
        }
    }
}








