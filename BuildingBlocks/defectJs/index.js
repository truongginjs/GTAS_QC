var fs = require("fs");
var $ = require("jquery")
$.csv = require("jquery-csv");

var sample = "./defect.csv";
fs.readFile(sample, "UTF-8", (err, csv) => {
  var data = $.csv.toObjects(csv);
  const clones = [];
  var newData = data.map((x) => {
    const { Code } = x;

    const result = {
      Code,
      DefectTypes: fix(x.DefectTypes),
      Reasons: fix(x.Reasons),
      Solutions: fix(x.Reasons),
      Handler: fix(x.Handler),
      Timeline: fix(x.Timeline),
    };
    // if(!Code){
    //   console.log(x);
    //   return;
    // }

    if (Code.startsWith("C"))
      clones.push(
        { ...result, Code: Code.replace("C", "E") },
        { ...result, Code: Code.replace("C", "R") }
      );
    if (Code.startsWith("T"))
      clones.push({ ...result, Code: Code.replace("T", "N") });
    if (Code.startsWith("P"))
      clones.push({ ...result, Code: Code.replace("P", "V") });
    return result;
  });

  newData.push(...clones);

  // console.log(newData.filter(x=>!x.Code))

  newData.forEach((element) => {
    element.ZoneTypeId = key[element.Code[0]];
  });

  fs.writeFileSync("./data.json", JSON.stringify(newData, undefined, 2));
  //   console.log(newData[35]);
  //   console.log(data)
});

const fix = (text) => {
  return text
    .split(/\n|-/)
    .filter((v) => v)
    .map((y) => {
      const temp = y.split("/").map((v) => v.trim());
      return { vi: temp[0], en: temp[1] };
    });
};

var key = {
  M: "07f7d8a4-3ea3-44eb-bf5e-dd04dc064da3",
  N: "63892f60-c8cb-40de-b365-e52f66a04ec4",
  T: "f34e7928-c4f0-4f84-95f7-335d73196358",
  C: "5ea2209a-9782-4cda-a4ba-71a4f5a53964",
  E: "de72a6a9-bd09-48e3-b48e-19494d3ddb43",
  R: "1bc43632-e605-4489-8030-f7dad305f00c",
  S: "ca691bec-ae50-4884-9e5e-7e6f84b24087",
  W: "cd6aac51-979f-499b-a9bc-55681caf2956",
  F: "3fe931f7-728b-48e6-b37c-828f683f9229",
  V: "c414c4a2-eca1-4cc3-b598-99d7f1c5b1ec",
  P: "7ced9b1f-31ad-4452-a625-81f48afe0e24",
};
