const BASE_URL = import.meta.env.VITE_API_URL || "http://localhost:5295";

async function request(path, { method = "GET", body, params } = {}) {
  let url = `${BASE_URL}/${path.replace(/^\//, "")}`;

  if (params) {
    const qs = new URLSearchParams(
      Object.entries(params).filter(
        ([, v]) => v !== undefined && v !== null && v !== ""
      )
    ).toString();
    if (qs) url += `?${qs}`;
  }

  const opts = { method, headers: {} };
  if (body !== undefined && body !== null) {
    opts.headers["Content-Type"] = "application/json";
    opts.body = JSON.stringify(body);
  }

  let res;
  try {
    res = await fetch(url, opts);
  } catch {
    throw new Error(
      "Ne mogu da se povežem sa serverom. Proverite da li je backend pokrenut."
    );
  }

  const text = await res.text();
  let data = null;
  if (text) {
    try {
      data = JSON.parse(text);
    } catch {
      data = text;
    }
  }

  if (!res.ok) {
    const message =
      typeof data === "string"
        ? data
        : data?.title || data?.message || res.statusText;
    throw new Error(message || `Greška ${res.status}`);
  }

  return data;
}

export const api = {
  get: (path, params) => request(path, { method: "GET", params }),
  post: (path, body, params) => request(path, { method: "POST", body, params }),
  put: (path, body, params) => request(path, { method: "PUT", body, params }),
  del: (path, body) => request(path, { method: "DELETE", body }),
};

export { BASE_URL };
