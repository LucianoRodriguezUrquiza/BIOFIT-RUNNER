import pathlib
import subprocess
import unittest

ROOT = pathlib.Path(__file__).resolve().parents[1]

class RunnerRepositoryContracts(unittest.TestCase):
    """Pruebas estructurales: NO compilan Unity ni prueban Android/BLE."""

    def test_upstream_is_a_gitlink_not_republished_assets(self):
        tracked = subprocess.check_output(["git", "ls-files", "--stage"], cwd=ROOT, text=True)
        entry = [line for line in tracked.splitlines() if line.endswith("\tThirdParty/TrashDash-Upstream")]
        self.assertEqual(len(entry), 1)
        self.assertTrue(entry[0].startswith("160000 "), entry)

    def test_no_third_party_assets_tracked_under_assets(self):
        names = subprocess.check_output(["git", "ls-files"], cwd=ROOT, text=True).splitlines()
        prohibited = [p for p in names
                      if p.startswith("Assets/") and
                      not (p.startswith("Assets/BIOFIT-RUNNER/") or p == "Assets/BIOFIT-RUNNER.meta")]
        self.assertEqual(prohibited, [], prohibited)

    def test_commands_have_explicit_api(self):
        src = (ROOT / "Assets/BIOFIT-RUNNER/Scripts/BiofitRunnerInputBridge.cs").read_text(encoding="utf-8")
        for method in ("SendLeft", "SendRight", "SendJump", "SendSlide", "TrySubmitAction"):
            self.assertIn(" " + method + "(", src)
        self.assertIn("#if ENABLE_LEGACY_INPUT_MANAGER", src)
        self.assertIn("UnityEvent<int>", src)

    def test_setup_docs_and_license_warning(self):
        guide = (ROOT / "docs/BASE_TRASH_DASH.md").read_text(encoding="utf-8")
        self.assertIn("Asset Store", guide)
        self.assertIn("2019.3", guide)
        self.assertIn("2.0.0", guide)
        gitignore = (ROOT / ".gitignore").read_text(encoding="utf-8")
        self.assertIn("/Assets/*", gitignore)
        self.assertIn("!/Assets/BIOFIT-RUNNER/", gitignore)

if __name__ == "__main__":
    unittest.main()
