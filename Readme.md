# Notes

Tracing screenshots are captured when calling Report.Log()/Info()/..., not by just action on the repo-item

If tracing screenshots are made in mode TestReport.ScreenshotMode.Background, screencapturing does not work entirely as expected as subsequent calls to Report.Info() without any delay/interactions between appear to confuse the attribution of screenshots to Report-items such that more than the standard of 3 tracing screenshots will appear. This can be solved by having some automation actions or delays in between.

When running the whole testsuite, for module execution in turbo mode it is sufficient to change the corresponding values in program.cs. When modules are started individually, individual module settings will apply.