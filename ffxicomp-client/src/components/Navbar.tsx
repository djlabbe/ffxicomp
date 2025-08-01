import { useState } from "react";
import { Link, useLocation } from "react-router-dom";
import logo from "../assets/icon.png";

export function Navbar() {
  const location = useLocation();
  const [menuOpen, setMenuOpen] = useState(false);

  const isActive = (path: string) =>
    location.pathname === path
      ? "bg-primary text-primary-foreground"
      : "hover:bg-muted hover:text-foreground text-muted-foreground";

  return (
    <header className="bg-background text-foreground shadow mb-6 border-b border-border dark:bg-gray-900 dark:text-gray-100 dark:border-gray-700">
      <div className="mx-auto px-4 py-4 flex flex-col sm:flex-row items-start sm:items-center justify-between gap-4">
        <div className="flex items-center space-x-3 w-full sm:w-auto">
          <img src={logo} alt="FFXI Compare Logo" className="h-8 w-8" />
          <h1 className="text-2xl">FFXI Compare</h1>
          <small>(Alpha)</small>
          {/* Hamburger button for mobile */}
          <button
            className="sm:hidden ml-auto p-2 rounded hover:bg-muted focus:outline-none"
            aria-label="Toggle menu"
            onClick={() => setMenuOpen((open) => !open)}
          >
            <svg
              className="w-6 h-6"
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              {menuOpen ? (
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M6 18L18 6M6 6l12 12"
                />
              ) : (
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth={2}
                  d="M4 6h16M4 12h16M4 18h16"
                />
              )}
            </svg>
          </button>
        </div>
        {/* Collapsible nav */}
        <nav
          className={`flex-col gap-2 w-full sm:w-auto sm:flex-row sm:flex ${
            menuOpen ? "flex" : "hidden"
          } sm:items-center`}
        >
          <Link
            to="/"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
              "/"
            )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
            onClick={() => setMenuOpen(false)}
          >
            Compare Sets
          </Link>
          <Link
            to="/browse"
            className={`px-4 py-2 rounded transition-colors duration-150 ${isActive(
              "/browse"
            )} dark:hover:bg-gray-800 dark:hover:text-white dark:text-gray-400`}
            onClick={() => setMenuOpen(false)}
          >
            Browse Gear
          </Link>
        </nav>
      </div>
    </header>
  );
}
