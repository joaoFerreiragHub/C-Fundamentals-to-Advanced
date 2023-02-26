import React from "react";
import { useLocation } from "react-router-dom";

export default function Contact() {
  const queryString = useLocation().search;

  const queryParams = new URLSearchParams(queryString);
  const name = queryParams.get("name");

  return (
    <div>
      <h2>Hey {name}, Contact us here..</h2>
      <p>
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Repudiandae
        architecto quibusdam laboriosam, illo culpa accusantium amet quod in?
        Voluptates aspernatur et sint beatae reiciendis quasi, non repellat
        animi deleniti dignissimos?
      </p>
    </div>
  );
}
