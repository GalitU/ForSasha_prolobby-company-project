import { useState, useEffect } from "react";

import { Ifexist } from "../../../repeat/user-if-exist";
export const UseValueLoginOwner = () => {
  let { userDataRow, user } = Ifexist({});

  const [firstName, setFirstName] = useState(user.name);
  const [lastName, setLastName] = useState(user.family_name);
  const [email, setEmail] = useState(user.email);
  const [phoneNumber, setPhoneNumber] = useState(user.phone_number);

  let userFirstName = "";
  let userLastName = "";
  let userEmail = "";
  let userPhoneNumber = "";

  // if (userDataRow === null) {
  //   console.log("if");
  //   userFirstName = user.name;
  //   console.log("if : " + userFirstName);
  //   userEmail = user.email;
  //   userLastName = user.family_name;
  //   userPhoneNumber = user.phone_number;
  //   console.log("if : " + userPhoneNumber);
  // }

  if (userDataRow != null) {
    console.log("else");
    userFirstName = userDataRow.FirstName;
    userEmail = userDataRow.Email;
    userLastName = userDataRow.LastName;
    userPhoneNumber = userDataRow.Phone_number;
  }

  console.log(firstName, lastName, email, phoneNumber);
  return {
    defaultVariables: {
      userFirstName,
      userLastName,
      userEmail,
      userPhoneNumber,
    },
    UseStatsVariables: {
      firstNameV: { firstName, setFirstName },
      lastNameV: { lastName, setLastName },
      emailV: { email, setEmail },
      phoneNumberV: { phoneNumber, setPhoneNumber },
    },
    UserDataRowV: { userDataRow },
  };
};
