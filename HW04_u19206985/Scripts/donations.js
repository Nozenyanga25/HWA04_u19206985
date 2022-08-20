function firstFunc() {
    window.open("https://www.paypal.com/donate/?cmd=_s-xclick&hosted_button_id=LNEEWX67WYT54&source=url");
}

function secondFunc() {
    window.open("https://thegivingblock.com/donate/weforest/");
}

function funcBrazilDonate() {
    window.open("https://www.globalgiving.org/projects/reconnecting-the-atlantic-forest-brazil/");
}

function funcEthiopiaDonate() {
    window.open("https://www.globalgiving.org/projects/forest-landscape-restoration-in-northern-ethiopia/");
}

function funcAmharaDonate() {
    window.open("https://www.globalgiving.org/projects/forest-landscape-restoration-in-northern-ethiopia/");
}

function funcBel() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/landing/WeForest?lang=en_EN");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of Belgium, the Netherlands, Luxembourg or Denmark and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";

}

function funcAus() {

    let text = "contact us";
    let link = text.link("mailto:contact@weforest.org");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = " Please " + link + " to check the process.";
}

function funcFra() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/landing/WeForest?lang=en_EN");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of France and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";
}

function funcGer() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/landing/WeForest?lang=en_EN");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of Germany and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";
  
}

function funcIta() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/page/Landing/en_EN?_origin_url_=%2Flanding%2FWeForest%3Flang%3Den_EN&reserved_beneficiary=WeForest&cid=14");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of Italy and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";
}

function funcSpa() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/landing/WeForest?lang=en_EN");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of Spain and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";
}

function funcSwi() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/landing/WeForest?lang=en_EN");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of Switzerland and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";
}

function funcUni() {

    document.getElementById("demo").innerHTML = "Donors living in the UK can make a donation via the Charities Aid Foundation. Before making your donation, please contact the Charities Aid Foundation to make arrangements at tge@cafonline.org or T. +44 30 00 12 33.";

    let text = "Please note that the minimum donation for tax deductibility in England, Northern Ireland, Wales and Scotland is £250. If the amount you want to donate is less than £250, there is no benefit to using the TGE mechanism. Please use standard bank transfer or Paypal.";
    document.getElementById("demo1").innerHTML = text.italics();
}

function funcUnis() {

    let text = "this link";
    let link = text.link("https://donate.transnationalgiving.eu/landing/WeForest?lang=en_EN");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "If you are a resident of the US and would like to make a tax deductible donation to WeForest, you can do so by following " + link + ".";
}

function funcWF() {

    let text = "contact us";
    let link = text.link("mailto:contact@weforest.org");

    document.getElementById("demo1").innerHTML = " ";
    document.getElementById("demo").innerHTML = "For a tax-efficient donation from another country, please " + link + " to check the process.";
}